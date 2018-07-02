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
    public class CommandManagerTests
    {
        [TestMethod()]
        public void ActionAddTest()
        {
            string command = "add planet Mars";
            string[] parsedCommand = command.Split(' ');

            int planetsCountBeforeAddition = Scene.AllPlanets.Count();
            CommandManager.ActionAdd(parsedCommand);
            int planetsCountAfterAddition = Scene.AllPlanets.Count();
            Assert.Equals(planetsCountBeforeAddition + 1, planetsCountAfterAddition);
        }

        [TestMethod()]
        public void ActionDestroyTest()
        {
            string command1 = "add planet Mars";
            string command2 = "destroy Mars";

            CommandManager.ActionAdd(command1.Split(' '));
            CommandManager.ActionDestroy(command2.Split(' '));

            int expectedPlanetsCountAfterDestruction = 0;
            int actualPlanetsCountAfterDestruction = Scene.AllPlanets.Count();

            Assert.Equals(expectedPlanetsCountAfterDestruction, actualPlanetsCountAfterDestruction);
        }

        [TestMethod()]
        public void ActionKillTest()
        {
            string command = "add planet Mars";
            string[] parsedCommand = command.Split(' ');

            string command2 = "add Mars human 3";
            string command3 = "destroy Mars";

            CommandManager.ActionAdd(parsedCommand);
            CommandManager.ActionAdd(command2.Split(' '));

            CommandManager.ActionDestroy(command3.Split(' '));
            int expectedCitizensCountAfterKill = 0;
            int actualCitizensCountAfterKill = Scene.AllPlanets[0].citizens.Count();

            Assert.Equals(expectedCitizensCountAfterKill, actualCitizensCountAfterKill);
        }
    }
}