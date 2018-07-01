using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
   public static class Scene
   {
     public static List<Planet> AllPlanets=new List<Planet>();
     private static RandomG name=new RandomG();

     // Iterate trough the citizens of the planets to delete the entity.
     public static removeEntity(entity) 
     {
         for (int i = 0; i < this.AllPlanets.Count(); i++)
         {    
            for (int k = 0; k < this.AllPlanets[i].citizens.Count(); k++)
            {
               if (this.AllPlanets[i].citizens[k]==targetEntity)
               {
                  this.AllPlanets[i].citizens[k] = null;
               }                      
            }                   
         }
     }

     // Create a creatute on a planet.
     public static void CreateEntity(EntityType creature, Planet planet)
     {
         switch(creature)
         {              
            case EntityType.animal:                 
               Animal a = new Animal(name.RandomName());
               planet.AddCitizen(a);
               break;

            case EntityType.entity:
               Entity e = new Entity(name.RandomName());
               planet.AddCitizen(e);
               break;

            case EntityType.god:
               God g = new God(name.RandomName());
               planet.AddCitizen(g);
               break;

            case EntityType.human:
               Human h = new Human(name.RandomName());
               planet.AddCitizen(h);
               break;

            case EntityType.unknown:
               Entity u = new Entity(name.RandomName());
               planet.AddCitizen(u);
               break;

            default:
               throw new ArgumentOutOfRangeException("there is no such type of creature");
               break;          
         }        
      }
   }
}
