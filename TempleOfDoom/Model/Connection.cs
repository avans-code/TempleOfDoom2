using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleOfDoom.Model
{
    public class Connection
    {
        public int NORTH { get; set; }
        public int SOUTH { get; set; }
        public Door[] doors { get; set; }
        public int WEST { get; set; }
        public int EAST { get; set; }
    }
}
