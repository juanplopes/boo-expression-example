using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boo.Lang.Compiler;
using Boo.Lang.Compiler.Pipelines;
using Boo.Lang.Compiler.IO;
using Boo.Lang.Compiler.Steps;

namespace ExampleExpressionCompiler
{
    public class ExpressionCompiler
    {
        public IEnumerable<string> LastExpressionParams
        {
            get { return step.Variables; }
        }

        BooCompiler boo = new BooCompiler();
        CustomDuckTypeExpanderStep step = new CustomDuckTypeExpanderStep();

        public ExpressionCompiler()
        {
            boo.Parameters.Pipeline = new CompileToMemory().Replace(
                typeof(ProcessMethodBodiesWithDuckTyping), step);
        }

        public Func<IDictionary<string, object>, object> Compile(string script)
        {
            boo.Parameters.Input.Clear();
            var realScript = MakeScript(script);

            boo.Parameters.Input.Add(new StringInput("Script", realScript));
            var compiler = boo.Run();
            if (compiler.Errors.Count > 0)
                throw compiler.Errors[0];

            var assembly = compiler.GeneratedAssembly;
            var method = assembly.GetType("ScriptModule").GetMethod("evaluate");
            return dictionary => method.Invoke(null, new[] { dictionary });
        }

        private static string MakeScript(string script)
        {
            return string.Format("import System\ndef evaluate(values):\n   return {0}", script);
        }
    }
}
