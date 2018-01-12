using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Manti
    {
        private Testo[] testo;
        private Luk luk;
        private Specii specii;
        private Potato[] potato;

        private bool ReadyToGo { get { return Check(); } }
        public void Init()
        {
            
            testo = new Testo[10];
            potato = new Potato[5];
        }

        public void AddTesto(Testo t)
        {
            for (int i = 0; i < testo.Length; i++)
            {
                if (testo[i] == null)
                {
                    testo[i] = t;
                    return;
                }
            }
        }

        public void AddPotato(Potato p)
        {

            for (int i = 0; i < potato.Length; ++i)
            {
                if (potato[i] == null)
                {
                    potato[i] = p;
                    return;
                }
            }


        }

        public void AddPriprava(Specii s)
        {
            specii = s;
        }

        public void AddLuk(Luk l)
        {
            luk = l;
        }
        

        private bool Check()
        {
            if (testo.Length == 0)
            {
                return false;
            }
            if (potato.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < testo.Length; i++)
            {
                if (testo[i] == null)
                {
                    return false;
                }
            }
            for (int i = 0; i < potato.Length; i++)
            {
                if (potato[i] == null)
                {
                    return false;
                }
            }
            
            return true;
        }


        
        private int has_ready = 0;

        public int Has_ready { get { return has_ready; } }
        public void GetHeat()
        {
            if (has_ready < 10)
            {
                has_ready++;
            }
        }
        public double Count { get; set; }
    }
}
