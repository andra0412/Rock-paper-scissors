using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PHF;

namespace PHFtest {
    [TestClass]
    public class UnitTest1 { 
        class ForeverRock : IComputerStrategy {
            public Game.Move GetMove() => Game.Move.Rock;
        }

        class ForeverPaper : IComputerStrategy {
            public Game.Move GetMove() => Game.Move.Paper;
        }

        [TestMethod]
        public void TestMethod1() {
            var expectedOutcomeText = "Ai pierdut!";

            Game.ComputerStrategy = new ForeverPaper();

            Assert.AreEqual(expectedOutcomeText, Game.Instance.Play(Game.Move.Rock).Text);
        }

        [TestMethod]
        public void TestMethod2() {
            var expectedOutcomeText = "Egalitate";

            Game.ComputerStrategy = new ForeverRock();

            Assert.AreEqual(expectedOutcomeText, Game.Instance.Play(Game.Move.Rock).Text);
        }

        [TestMethod]
        public void TestMethod3() {
            var expectedOutcomeText = "Ai castigat!";

            Game.ComputerStrategy = new ForeverPaper();

            Assert.AreEqual(expectedOutcomeText, Game.Instance.Play(Game.Move.Scissors).Text);
        }
    }
}
