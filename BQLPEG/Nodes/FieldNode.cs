using System.Collections.Generic;

namespace BQLPEG.Nodes
{
    public class FieldNode :Node
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public IEnumerable<int> TypeParams { get; set; }
        public bool Nullable { get; set; }
    }
}