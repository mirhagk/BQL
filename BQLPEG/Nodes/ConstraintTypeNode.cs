using System.Collections.Generic;

namespace BQLPEG.Nodes
{
    public abstract class ConstraintTypeNode :Node 
    {
    }
    public class PKConstraintTypeNode : ConstraintTypeNode
    {
        public IEnumerable<string> Ids { get; set; }
    }
    public class UKConstraintTypeNode :ConstraintTypeNode
    {
        public IEnumerable<string> Ids { get; set; }
    }
    public class NotNullConstraintTypeNode : ConstraintTypeNode
    {
        public IEnumerable<string> Ids { get; set; }
    }
    public class FKConstraintTypeNode : ConstraintTypeNode
    {
        public IEnumerable<string> LocalIds { get; set; }
        public string ForeignTable { get; set; }
        public IEnumerable<string> ForeignIds { get; set; }
    }
}