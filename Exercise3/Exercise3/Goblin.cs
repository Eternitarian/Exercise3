using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Goblin : Monster
    {

        public Goblin( Weapon currentWeapon) : base("Goblin", 80, 80, 0.5f, 20, currentWeapon, 20, 1)
        {
            m_cCurrentWeapon = currentWeapon;
        }
        public override void PrintStats()
        {
           
            base.PrintStats();
            Console.WriteLine("goblin looks at you angry, Grunts and spits at your feet");

        }

    }
}
