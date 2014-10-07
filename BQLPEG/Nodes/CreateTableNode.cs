using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BQLPEG.Nodes
{
    class CreateTableNode :StatementNode
    {
        public string Name { get; set; }
        public IEnumerable<FieldNode> Fields { get; set; }
        public IEnumerable<ConstraintNode> Constraionts { get; set; }
    }
}
