namespace BQLPEG.Nodes
{
    public class ConstraintNode :Node, ITableDefNode
    {
        public string Name { get; set; }
        public ConstraintTypeNode ConstraintType { get; set; }
    }
}