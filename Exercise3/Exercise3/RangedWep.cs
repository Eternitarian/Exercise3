using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class RangedWep : Weapon
    {
        public enum RangedWepType { Crossbow, Bow, Gun, Wand };
        public int m_iAmmo;
        //int m_iShotsBeforeReload;
        //int reloadDuration;
        public int temp;

        
       
        public RangedWep(string WepName, float attackRate, int dammage, float wepRange,float value, ItemUse itemtype) :base(WepName,attackRate, dammage,wepRange,value, itemtype)
        {
           

        
        
        
        }



        public void attack()
        {
            //attack vatiation reload ect
            switch (temp)
            {

                case 0:
                    
                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;


            }

        
        
        
        }
    }
}
