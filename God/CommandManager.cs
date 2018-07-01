using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
   // This class parses and executes user's commands. 
   ///Add Planet syntax: <add>|<name_of_new_planet>
   ///Add Entities to a Planet syntax: <add> <name_planet> <entity|animal|human|god> <number_of_creatures>
   ///Kill creatures of the planet syntax:<kill>|<name_planet>
   ///Destroy entire planet syntax: <destroy>|<name_planet> 
   ///Statistic syntax: <statistic>
    public static class CommandManager
    {
        // Command Add for adding planets or entites to planets.
        public static void ActionAdd(string[] commands) 
        {
            // Add planet.
            if (commands.Length == 3 && commands[1] == "planet")
               {
                  Planet m = new Planet(commands[2]);
                  Scene.AllPlanets.Add(m);
                  Console.WriteLine("You add planet:{0}", Scene.AllPlanets.ElementAt(Scene.AllPlanets.Count - 1).Name);
               }

            // Add creature to a planet.
            if(commands.Length==4)
            {
               for (int i = 0; i < Scene.AllPlanets.Count(); i++)
               {    
                  if (Scene.AllPlanets[i].Name == commands[1])
                  {
                     int m = int.Parse(commands[3]);
                     EntityType type = (EntityType)Enum.Parse(typeof(EntityType), commands[2]);                         
                     for (int k = 0; k < m; k++)
                     {
                        Scene.CreateEntity(type, Scene.AllPlanets[i]);
                     }     
                  }
               }
               Console.WriteLine("You added to planet:{0},{1} {2}", commands[1], commands[3], commands[2]);
            }
        }
        public static void Read()
        {
          string command = Console.ReadLine();
          string [] commands = command.Split(' ');

          switch(commands[0])
          {

            case "add":
                ActionAdd(commands);
                break;

            case "kill":
               foreach (Planet planet in Scene.AllPlanets)
               {
                  if (planet.Name == commands[1])
                  {
                     planet.citizens.Clear();
                  }
               }
               Console.WriteLine("You kill creatures of planet:{0}", commands[1]);
               break;

           
            case "destroy":
               for (int i = 0; i < Scene.AllPlanets.Count; i++)
               {
                  if(Scene.AllPlanets[i].Name==commands[1])
                  {
                     Scene.AllPlanets.RemoveAt(i);
                     Console.WriteLine("You destroyed planet:{0}", commands[1]);
                  }              
               }                 
            break;

            case "statistic":
                if (Scene.AllPlanets.Count != 0)
                {
                    Console.WriteLine(Scene.AllPlanets.Count());
                    foreach (var planet in Scene.AllPlanets)
                    {  
                        Console.WriteLine(planet);
                        foreach (var cit in planet.citizens)
                        {
                           Console.WriteLine(cit);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("there are no planets created");
                }
                break;

            case " ":
                break;

            default:
                Console.WriteLine("Wrong command");
                break;
         }
         
         CommandManager.Read();        
        }
    }
}
