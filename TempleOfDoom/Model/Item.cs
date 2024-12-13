using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleOfDoom.Model
{
    public class Item
    {
        public string type { get; set; }
        public int damage { get; set; }
       public Position position { get; set; }
        public string color { get; set; }
    }
}
