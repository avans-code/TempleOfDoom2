using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleOfDoom.Model
{
    public class GameData
    {
        public Room[] rooms { get; set; }
        public Connection[] connections { get; set; }
        public Player player { get; set; }
    }
}
