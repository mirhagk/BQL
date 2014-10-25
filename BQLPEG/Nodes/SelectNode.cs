using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BQLPEG.Nodes
{
    class SelectStatementNode : StatementNode, ITableExpression
    {
        public SelectClauseNode SelectClause { get; set; }
        public FromClauseNode FromClause { get; set; }
        public WhereClauseNode WhereClause { get; set; }
    }
    class FromClauseNode :Node
    {
        public IEnumerable<string> TableIds { get; set; }
    }
    class SelectClauseNode : Node
    {
        public bool Distinct { get; set; }
        public string IntoTableId { get; set; }
        public IColumnListNode ColumnList { get; set; }
    }
    interface IColumnListNode{

    }
    class WhereClauseNode :Node
    {
        public IExpression Expression { get; set; }
    }
    class ColumnNameListNode:IColumnListNode
    {
        public IEnumerable<string> Ids { get; set; }
    }
    class AllColumnsListNode : IColumnListNode, IExpression { }
}
