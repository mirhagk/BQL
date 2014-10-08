namespace BQLPEG.Nodes
{
    public class ConstraintNode :Node
    {
        public string Name { get; set; }
        public ConstraintTypeNode ContraintType { get; set; }
    }
}