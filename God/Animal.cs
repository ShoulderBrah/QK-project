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

        public void Eat()
        {
            this.State = State.Eating;
            this.Weight += RandomG.RandomNumbers(1, 5);
        }

        public void SearchingForFood()
        {
            this.State = State.SearchingForFood;
            this.Energy -= RandomG.RandomNumbers(0, 20);

        }

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
                this.State = State.Attacking;
            }
            else if (nextNum >= -50 && nextNum < 0)
            {
                this.State = State.Sleeping;
            }
            else if (nextNum >= 0 && nextNum < 50)
            {
                this.State = State.Sleeping;
            }
            else if (nextNum >= 50 && nextNum < 100)
            {
                this.State = State.SearchingForFood;
            }
            else
            {
                this.State = State.Moving;
            }
        }

        public override string ToString()
        {
            return "Animal: " + "Name " + this.Name;
        }
    }
}
