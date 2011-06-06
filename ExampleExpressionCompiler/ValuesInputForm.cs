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
    public partial class ValuesInputForm : Form
    {
        public IDictionary<string, object> Values
        {
            get { return values.ToDictionary(x => x.Key, x => (object)x.Value); }
        }

        IList<DecimalInput> values;
        public ValuesInputForm(string[] names)
        {
            Array.Sort(names);
            InitializeComponent();
            values = names.Select(x => new DecimalInput(x, 0m)).ToList();
            decimalInputBindingSource.DataSource = values;
            Grid.DataSource = decimalInputBindingSource;
        }

        private void OkCommand_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
