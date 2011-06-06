using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExampleExpressionCompiler
{
    public partial class ScriptInputForm : Form
    {
        public ScriptInputForm()
        {
            InitializeComponent();
        }

        private void EvaluateCommand_Click(object sender, EventArgs e)
        {
            try
            {
                var compiler = new ExpressionCompiler();
                var function = compiler.Compile(ScriptInput.Text);
                var input = compiler.LastExpressionParams.ToArray();
                var form = new ValuesInputForm(input);
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var result = function(form.Values);
                    MessageBox.Show(string.Format("The result is: {0}", result), "Result");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
