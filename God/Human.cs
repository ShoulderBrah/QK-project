using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    // Unlike Animal the Humans special action is analyzing.
    public class Human:Animal
    {
         public Human():base()
        { 
        
        }

        public Human(string name):base(name)
        {
        
        }

        public Human(string name,double energy,double power,double size,double weight, Point2D a,State b)
            :base(name, energy, power, size, weight,  a, b)
        {
            
        }

        public void Analyze()
        {
            this.State = State.Analyzing;
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
            else if (nextNum >= 100 && nextNum < 150)
            {
                this.Move(new Point2D);
            }
            else
            {
                this.Analyze();
            }

        }

        public override string ToString()
        {
            return "Human: " + "Name " + this.Name;
        }
    }
}
