using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    
    public class Item
    {
        public enum ItemUse { attk, deff, sell, Unlockable, Consumable };

        public ItemUse m_eUsedFor
        { get; set; }
        public string m_sName { get; set; } 
        public float m_iItemValue { get; set; }

        public Item(string name,float value, ItemUse usedFor )
        {
            m_sName = name;
            m_iItemValue = value;
            m_eUsedFor = usedFor;
        }

        //weapons attack function
        public virtual int UseItem(float attackRate)
        {
          

            return 

        }
    }
   

}
