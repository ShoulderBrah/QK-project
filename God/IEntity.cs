using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
		public interface IEntity
		{
			// Location of the entity 
			Point2D Location { get; set; }

			// Name of the entity
			string Name { get; set; }

			// Energy points. Used during fighting.
			double Energy { get; set; }

			// Power points
			double Power { get; set; }

			// Size of the entity. Growing when eating.
			double Size { get; set; }

			// Weight of the entity. Growing when eating.
			double Weight { get; set; }

			// State of the entity. Changing after an action.
			State State { get; set; }
				
			// Attacking other entities.
			void Attack(IEntity targetEntity);

			// Moving to a new location.
			void Move(Point2D a);

			// Doing specific or random action.
			void DoAction(AEntity targetEntity);
		}
}
