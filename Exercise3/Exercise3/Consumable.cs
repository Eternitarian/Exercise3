using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Consumable : Item
    {
        int m_iRegenValue
        { get; set; }
        // failure by fire (if you fail you die)
        //failure by frustration 
        //failing at the game is fine
        //failing to understand the instructions

        public Consumable(int regenVal, string name,float value,ItemUse item) :base(name,value,item)
        {
            m_iRegenValue = regenVal;

        
        }
        protected void DisplayBenifits()

        {
            Console.WriteLine("this is an "+m_sName+ "it heals "+m_iRegenValue +" health"  );
        
        }


    }
}
