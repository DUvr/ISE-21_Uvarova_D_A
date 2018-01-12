using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Knife
    {
        public void Clean_and_Rezka(Potato p)
        {
            if (p.Have_skin)
            {
                p.Have_skin = false;
            }
        }

        public void Have_parts(Testo t)
        {
            if (t.Have_parts)
            {
                t.Have_parts = false;
            }
        }
    }
}
