using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleExpressionCompiler
{
    public class DecimalInput
    {
        public DecimalInput() { }
        public DecimalInput(string key, decimal value)
        {
            this.Key = key;
            this.Value = value;
        }
        public string Key { get; set; }
        public decimal Value { get; set; }
    }
}
