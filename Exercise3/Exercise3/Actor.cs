using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise3
{
   
    class Actor
    {
        Arena thisGame = new Arena();
       

      
        //Actors special traits
        protected enum AdjectiveFeatures { Tankish, Lean, Glowing, Sporish };
        //different states the enemy/player can be in
        protected enum StateMachine { Attack, Defend, Heal, Die, Trade, Travel };

        protected StateMachine CurrentState =  StateMachine.Attack;
        #region
        //Name of char
        protected string m_sName { get; set; }
        //health cap
        public int m_iMaxHealth { get; set; }
        //health
        public int m_iHealth { get; set; }

        //amount of attacks per turn 0.1 < how everlong 
        public float m_fAttackSpeed { get; set; }
      
        //strength
        public int m_iStrength{ get; set; }
        //current wep
        public Weapon m_cCurrentWeapon{ get; set; }
        //coins
        public float m_fCoins;

        //actors items 
        public List<Item> m_cItems =new List<Item>();
        //this players random class reference
        static Random rnd = new Random();



        #endregion
        //constructor for weapons to be passed in 


        public Actor(string name, int maxHealth, int health, float attkSpeed,int strength,Weapon currentWeapon, float Coins,int startItemAmount)
        {
            m_sName = name;
            m_iMaxHealth = maxHealth;
            m_iHealth = health;
            m_fAttackSpeed = attkSpeed;
            m_iStrength = strength;
            m_cCurrentWeapon = currentWeapon;
            m_fCoins = Coins;
            m_cItems = GenerateAbunchaItems(5);
            

        }
        //default constructor
        public Actor()
        { 
        
        }

        public virtual void PrintStats()
        {
            Console.WriteLine("this is a {0},{1},{2},{3}",
            m_sName,m_iStrength,m_iHealth,m_cCurrentWeapon);
			//if (allItems[i].m_eUsedFor == Item.ItemUse.Consumable)
			//{

			//}
		}

        


        //public void FindConsumable()
        //{
        //    for (int i = 0; i <= m_cItems.Count; i++)
        //    {
        //        if (m_cItems[i].m_eUsedFor.Equals (4))
        //        {
        //            Console.WriteLine(m_cItems[i].m_eUsedFor);
        //        }


        //    }
         
        //}
        public List<Item> GenerateAbunchaItems(int itemAmounts)
        {
            List<Item> temp = new List<Item>();
            

            for (int i = 0; i < itemAmounts; ++i)
            {
             
                temp.Add(Arena.allItems[GetRandomNumber(itemAmounts)]);
                Console.WriteLine(temp[i].m_sName);
            }

            return temp;
        }
        public int GetRandomNumber(int randomInt)
        {
            
            int randomItemNum = rnd.Next(0, 5);
            return randomItemNum; 
        }
       

    }
}
