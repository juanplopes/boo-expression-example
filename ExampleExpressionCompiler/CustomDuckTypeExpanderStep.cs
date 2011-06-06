using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boo.Lang.Compiler.Steps;
using Boo.Lang.Compiler.Ast;

namespace ExampleExpressionCompiler
{
    public class CustomDuckTypeExpanderStep : ProcessMethodBodiesWithDuckTyping
    {
        public IEnumerable<string> Variables { get { return variables; } }
        
        HashSet<string> variables = new HashSet<string>();

        public override void OnModule(Boo.Lang.Compiler.Ast.Module module)
        {
            variables.Clear();
            base.OnModule(module);
        }

        public override void OnReferenceExpression(ReferenceExpression node)
        {
            var entity = this.NameResolutionService.Resolve(node.Name);
            if (entity != null)
            {
                base.OnReferenceExpression(node);
            }
            else
            {
                var parameter = _currentMethod.GetParameters()[0];
                var dictionary = TypeSystemServices.Map(typeof(IDictionary<string, object>));

                var getter = NameResolutionService.ResolveMethod(dictionary, "get_Item");
                var propCall = CodeBuilder.CreateMethodInvocation(
                    CodeBuilder.CreateReference(parameter),
                    getter, 
                    CodeBuilder.CreateStringLiteral(node.Name));

                variables.Add(node.Name);

                BindExpressionType(propCall, TypeSystemServices.DuckType);
                node.ParentNode.Replace(node, propCall);
            }

        }
    }
}
