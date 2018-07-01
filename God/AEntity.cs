using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    public abstract class AEntity:IEntity
    {
        private static RandomG nameR = new RandomG();
        private string name;
        private double energy;
        private double power;
        private double size;
        private double weight;
        private Point2D location;
        private State state;

        private void killEntity(IEntity targetEntity)
        {
            Console.WriteLine("{0} is killed", targetEntity.Name);
            Scene.removeEntity(targetEntity);
        }

        public AEntity()
        {
            this.Name = nameR.RandomName();
            this.Energy = 10;
            this.Power = 10;
            this.Size = 10;
            this.Weight = 10;
            this.Location = new Point2D();
            this.State = State.Unknown;
        }

        public AEntity(string name)
        {
            this.Name = name;
            this.Energy = 10;
            this.Power = 10;
            this.Size = 10;
            this.Weight = 10;
            this.Location = new Point2D();
            this.State = State.Unknown;
        }

        public AEntity(string name, double energy, double power, double size, double weight,
         Point2D location, State b)
        {
            this.Name = name;
            this.Energy = energy;
            this.Power = power;
            this.Size = size;
            this.Weight = weight;
            this.Location = location;
            this.State = b;
        }

        public string Name 
        {
            get
            { 
                return this.name; 
            }
            set 
            {
                if(value==null)
                {
                    throw new ArgumentOutOfRangeException("The entity should have name");
                }
                this.name = value;
            }
        }

        public double Energy
        {
            get 
            {
                return this.energy;
            }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("The energy should be a positive number");
                } 
                this.energy = value;
            }
        }

        public double Power
        {
            get 
            { 
                return this.power; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The power should be a positive number");
                } 
                this.power = value;
            }
        }

        public double Size
        {
            get 
            { 
                return this.size; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The size should be a positive number");
                } 
                this.size = value;
            }
        }

        public double Weight
        {
            get 
            { 
                return this.weight; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The weight should be a positive number");
                } 
                this.weight = value;
            }
        }

        public Point2D Location
        {
            get
            {
                return this.location;
            }
            set
            {
                 this.location = value;
            }
        
        }

        public State State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }

        }

        // Attack an entity and calculate the result of the battle.
        public virtual void Attack(IEntity targetEntity)
        {
            RandomG rand = new RandomG();
            double damage = rand.RandomNumbers(10, 20);
            if ((targetEntity.Energy - damage) >= 0)
            {
                targetEntity.Energy -= damage;
                this.State = State.Attacking;
            }
            else
            {
                killEntity(targetEntity)
            }
        }

        public virtual void Move(Point2D newLocation)
        {
            this.Point = newLocation;
            this.State = State.Moving;
        }

        public virtual void DoAction(AEntity targetEntity)
        {
            this.Attack(targetEntity);
        }
        
        public override string ToString()
        {
            return "Entity: "+"Name "+this.Name;
        }
    }
}
