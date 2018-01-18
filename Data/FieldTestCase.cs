using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGenerator.Data
{
    public class FieldTestCase
    {
        public string DefaultValue { get; set; }

        public Queue<string> PositiveValues { get; set; }

        public Queue<string> NegativeValues { get; set; }
    }
}
