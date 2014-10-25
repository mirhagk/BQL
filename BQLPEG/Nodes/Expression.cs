using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BQLPEG.Nodes
{
    interface ITableExpression : IExpression { }
    interface IExpression { }
    class ExpressionList : ITableExpression
    {
        public IEnumerable<IExpression> Expressions { get; set; }
    }
}
