using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    public class Animal:AEntity
    {
         public Animal():base()
        { 
        
        }

        public Animal(string name, double energy, double power, double size, double weight, Point2D a, State b)
            :base(name, energy, power, size, weight,  a, b)
        {
            
        }

        public Animal(string name):base(name)
        {
        
        }

        // Eating increases animals weight by 1 to 5 points.
        public void Eat()
        {
            this.State = State.Eating;
            this.Weight += RandomG.RandomNumbers(1, 5);
        }

        // Searching for food decreases animals energy by 0 to 20 points.
        public void SearchingForFood()
        {
            this.State = State.SearchingForFood;
            this.Energy -= RandomG.RandomNumbers(0, 20);
        }

        // Sleeping increases animals energy by 100 to 120 points.
        public void Sleep()
        {
            this.State = State.Sleeping;
            this.Energy += RandomG.RandomNumbers(100, 120);
        }

        public override void DoAction(AEntity targetEntity)
        {
            double nextNum = RandomG.RandomNumbers(-100, 200);
            if (nextNum < -50)
            {
                this.Attack(targetEntity);
            }
            else if (nextNum >= -50 && nextNum < 50)
            {
                this.Sleeping();
            }
            else if (nextNum >= 50 && nextNum < 100)
            {
                this.SearchingForFood();
            }
            else
            {
                this.Move(new Point2D);
            }
        }

        public override string ToString()
        {
            return "Animal: " + "Name " + this.Name;
        }
    }
}
