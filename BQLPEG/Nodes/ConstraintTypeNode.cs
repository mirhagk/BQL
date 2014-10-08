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
}