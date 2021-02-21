using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise3
{
    class Weapon :Item
    {

        //name
       
        //damage
        int m_iDamage
        { get; set; }
        //range 
        float m_fRange
        { get; set; }
        float m_fWepAttackRate
        { get; set; }

        //grade enum cruddy, fair , high, ultra 

        public Weapon(string WepName,float attackRate, int dammage, float wepRange, float value,  ItemUse itemtype) : base(WepName, value, itemtype)
        {
           
            m_iDamage = dammage;
            m_fRange = wepRange;
            m_fWepAttackRate= attackRate;
        }


        public override int UseItem(float attackRate)
        {
            int damage = m_iDamage * (int)(1.0f/ attackRate );
           int amountofHits = (int)(10 / (m_fWepAttackRate * 10));
            float remainder = 10 - (amountofHits * (m_fWepAttackRate * 10));

            //10/3 =a
            //a

            //is to acess and update the attackrate variable
            //


            return 

        }




    }
}

