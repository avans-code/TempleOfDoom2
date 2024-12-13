using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempleOfDoom.Model
{
    public class Door
    {
        public string type { get; set; }
        public string color { get; set; }
        public int no_of_stones { get; set; }
        public Boolean closed {  get; set; }


        public void setClosed(Boolean closed)
        {
            this.closed = closed;
        }
        public Boolean GetClosed()
        {
            return this.closed;
        }

    }
}
