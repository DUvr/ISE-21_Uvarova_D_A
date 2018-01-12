using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Pan
    {
        private Water[] water;
        private Manti[] manti;
        

        private bool ReadyToGo { get { return Check(); } }
        public void Init(int countManti)
        {
            water = new Water[3];
            manti = new Manti[countManti];

        }

        public void AddWater(Water w)
        {
            for (int i = 0; i < water.Length; i++)
            {
                if (water[i] == null)
                {
                    water[i] = w;
                    return;
                }
            }
        }
      

        public void AddManti(Manti m)
        {
            for (int i = 0; i < manti.Length; i++)
            {
                if (manti[i] == null)
                {
                    manti[i] = m;
                return;
                }

            }
        }

        private bool Check()
        {
            if (water.Length == 0)
            {
                return false;
            }
            if (manti.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < water.Length; i++)
            {
                if (water[i] == null)
                {
                    return false;
                }
            }
            for (int i = 0; i < manti.Length; i++)
            {
                if (manti[i] == null)
                {
                    return false;
                }
            }
            return true;
        }

        public void GetHeat()
        {
            if (!Check())
            {
                return;
            }
            if(water.Length>0)
            {
                if(water[0].Temp<100)
                {
                    for (int i = 0; i < water.Length; i++)
                    {
                        water[i].GetHeat();
                    }
                    bool flag = false;
                    switch (water[0].Temp)
                    {
                        case 20:flag = true;break;
                        case 40: flag = true; break;
                        case 60: flag = true; break;
                        case 80: flag = true; break;
                        case 100: flag = true; break;
                    }
                    if(flag)
                    {
                        for (int i = 0; i < manti.Length; i++)
                        {
                            manti[i].GetHeat();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < manti.Length; i++)
                    {
                        manti[i].GetHeat();
                    }
                }     
            }
        }

        public bool IsReady()
        {
            for(int i = 0; i < water.Length; i++)
            {
                if (water[i].Temp < 100)
                {
                    return false;
                }
            }
            for(int i = 0; i < manti.Length; i++)
            {
                if (manti[i].Has_ready < 10)
                {
                    return false;
                }
            }
            return true;
        }

        public Water[] Drain()
        {
            return water;
        }
        
        public Manti[] GetManti()
        {
            return manti;
        }


    }
}
