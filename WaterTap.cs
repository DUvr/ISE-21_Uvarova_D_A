
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class WaterTap
    {
        public bool State { get; set; }

        public void Wash(Potato p)
        {
            if (State)
            {
                p.Dirty = 0;
            }
        }

        public Water GetWater()
        {
            if (State)
            {
                return new Water();
            }
            else
            {
                return null;
            }
        }
    }
}
