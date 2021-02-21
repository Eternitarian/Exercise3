using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Player : Actor
    {
        public int m_iCarryWeight { get; set; }
       


        public Player(string name, int maxHealth, int health, float attkSpeed, int strength, Weapon currentWeapon, float Coins, int startItemAmount) :base(name,maxHealth,health,attkSpeed,strength,currentWeapon,Coins, startItemAmount)
        { 
        
        }



        public virtual void Attack()
            {
            m_sName = "bobby";

            }




    }
}
