using Microsoft.VisualStudio.TestTools.UnitTesting;
using God;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God.Tests
{
    [TestClass()]
    public class AnimalTests
    {
        static string animalName = "TheBeast";
        Animal testAnimal = new Animal(animalName);

        [TestMethod()]
        public void AnimalEatingTest()
        {
            double animalEnergyBeforeEating = testAnimal.Energy;
            testAnimal.Eat();
            double animalEnergyAfterEating = testAnimal.Energy;

            Assert.IsTrue(animalEnergyBeforeEating < animalEnergyAfterEating);
            Assert.IsTrue(testAnimal.State == State.Eating);
        }

        [TestMethod()]
        public void AnimalSleepingTest()
        {
            double animalEnergyBeforeEating = testAnimal.Energy;
            testAnimal.Eat();
            double animalEnergyAfterEating = testAnimal.Energy;

            Assert.IsTrue(animalEnergyBeforeEating < animalEnergyAfterEating);
            Assert.IsTrue(testAnimal.State == State.Sleeping);
        }

        [TestMethod()]
        public void AnimalSearchingForFoodTest()
        {
            double animalEnergyBeforeSearching = testAnimal.Energy;
            testAnimal.Eat();
            double animalEnergyAfterSearching = testAnimal.Energy;

            Assert.IsTrue(animalEnergyBeforeSearching > animalEnergyAfterSearching);
            Assert.IsTrue(testAnimal.State == State.SearchingForFood);
        }

        [TestMethod()]
        public void AnimalToStringTest()
        {
            string expectedResult = "Animal: " + "Name " + animalName;
            string actualResult = testAnimal.ToString();

            Assert.Equals(expectedResult, actualResult);
        }
    }
}