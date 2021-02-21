using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Arena
    {
        public Arena()
            {

            }

       static public List<Item> allItems = new List<Item>()
        {
            ///1-10 are Consumables
          new Consumable(2, "bottle of some yellow goop", 1,Item.ItemUse.Consumable),
          new Consumable(5, "Apple", 2,Item.ItemUse.Consumable ),
          new Consumable(5,"Dried Pigs nose", 2, Item.ItemUse.Consumable),
          new Consumable(15, "5 day old soup", 8,Item.ItemUse.Consumable),
          new Consumable(15,"Potatye", 8, Item.ItemUse.Consumable),
          new Consumable(30,"Porridge", 18, Item.ItemUse.Consumable),
          new Consumable(30, "pie", 18,Item.ItemUse.Consumable),
          new Consumable(30, "Pizza Crust",18,Item.ItemUse.Consumable),
          new Consumable(30, "", 18,Item.ItemUse.Consumable),
          new Consumable(100, "you dont want to know", 35,Item.ItemUse.Consumable),
          //11-13 are Ranged weapons you can use
          new RangedWep("Traditional Bow",1,25,5,30, Item.ItemUse.attk),
          new RangedWep("CrossBow",2,50,5,40, Item.ItemUse.attk),
          new RangedWep("gun",3,50,5,40, Item.ItemUse.attk),
          //14-18 Melee weapons
          new Weapon("Lumpy Stick",1,10,1,40, Item.ItemUse.attk),
          new Weapon("Dagger",0.3f,8,0,40, Item.ItemUse.attk),
          new Weapon("long Sword",2.5f,60,2,40, Item.ItemUse.attk),
          new Weapon("Schimitar",0.5f,25,1,40, Item.ItemUse.attk),
          new Weapon("mace",0.6f,28,1,40, Item.ItemUse.attk)


    };

        public List<Actor> enemies = new List<Actor>()
        {
         new Orc((Weapon)allItems[14]),
         new Skeleton((Weapon)allItems[18]),
         new Goblin((Weapon)allItems[16])

        };
        public void PrintAllActors()
        {

            for (int i = 1;i< enemies.Count;i++ )
            {
				
				
                enemies[i].PrintStats();
            }
                
        }





    }
}
