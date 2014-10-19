using System.Collections.Generic;

namespace BQLPEG.Nodes
{
    interface ITableDefNode { }
    public class FieldNode : Node, ITableDefNode
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public IEnumerable<int> TypeParams { get; set; }
        public bool Nullable { get; set; }
    }
}