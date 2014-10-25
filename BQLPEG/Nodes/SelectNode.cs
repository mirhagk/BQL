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
    class SelectClauseNode : Node
    {
        public bool Distinct { get; set; }
        public string IntoTableId { get; set; }
        public IColumnListNode ColumnList { get; set; }
    }
    interface IColumnListNode{

    }
    class ColumnNameListNode:IColumnListNode
    {
        public IEnumerable<string> Ids { get; set; }
    }
    class AllColumnsListNode : IColumnListNode { }
}
