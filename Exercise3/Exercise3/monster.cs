using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Monster : Actor
    {
        public Monster (string name, int maxHealth, int health, float attkSpeed, int strength, Weapon currentWeapon, float Coins, int startItemAmount) : base(name,maxHealth,health,attkSpeed,strength,currentWeapon,Coins,startItemAmount) 
        {
            m_cCurrentWeapon = currentWeapon;     
        }
        //overide the print stats function
        public override void PrintStats()
        {
            Console.WriteLine("an unknown by the name of {0}, strength is {1}, health is {2}, current weapon is {3}",
            m_sName, m_iStrength, m_iHealth, m_cCurrentWeapon);

        }


    }
}
