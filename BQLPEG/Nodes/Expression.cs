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
    class StringLiteralExpression :Node, IExpression
    {
        public string Literal { get; set; }
    }
    class NumberLiteralExpression : Node,IExpression
    {
        public decimal Literal { get; set; }
    }
    class IdExpression : Node, IExpression
    {
        public string Id { get; set; }
    }
}
