using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BQLPEG.Nodes
{
    class SelectStatementNode : StatementNode, ITableExpression
    {
    }
    interface IColumnListNode{

    }
    class ColumnNameListNode:IColumnListNode
    {
        public IEnumerable<string> Ids { get; set; }
    }
    class AllColumnsListNode : IColumnListNode { }
}
