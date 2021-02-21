using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Orc : Monster
    {



        //constructor sets skeletons with base values for skelletons 
        public Orc(Weapon currentWeapon) : base("Orc", 80, 80, 0.5f, 20, currentWeapon, 15, 4)
        {
            m_cCurrentWeapon = currentWeapon;
        }
        public override void PrintStats()
        {
            Console.WriteLine("a skelly named  {0}, strength is {1}, health is {2}, current weapon is {3}",
            m_sName, m_iStrength, m_iHealth, m_cCurrentWeapon);

        }

    }
}