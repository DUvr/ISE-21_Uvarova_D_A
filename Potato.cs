using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Potato
    {
       
        private int dirty = 10;

        //кожура и порезана
        public bool Have_skin { get; set; }

        

        public int Dirty { set { if (value > -1 && value < 11) dirty = value; } get { return dirty; } }
        
    }
}
