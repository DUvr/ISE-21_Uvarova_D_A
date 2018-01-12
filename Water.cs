using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Water
    {
        private int temp = 0;
        public int Temp { get { return temp; } }
        public void GetHeat()
        {
            if (temp < 100)
            {
                temp++;
            }
        }
    }
}
