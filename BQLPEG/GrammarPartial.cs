using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BQLPEG
{
    partial class Grammar
    {
        private string Flatten(IEnumerable<string> values)
        {
            return string.Concat(values);
        }
    }
}
