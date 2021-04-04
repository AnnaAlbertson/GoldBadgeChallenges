using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Challenge4_Repository;
using System.Collections.Generic;

namespace Challenge4_UnitTests
{
    [TestClass]
    public class UnitTests
    {
        private Outing_Repo repo = new Outing_Repo();
        [TestMethod]
        public void Test_GetListOfOutings()
        {
            //Arrange
            //Act
            List<Outing> localList = repo.GetListOfOutings();
            //Assert
            Assert.IsNotNull(localList);
        }
        [TestMethod]
        public void Test_AddOuting()
        {
            //Arrange
            List<Outing> localList = repo.GetListOfOutings();
            Outing outing = new Outing();
            //Act
            int initialCount = localList.Count;
            repo.AddOuting(outing);
            int result = localList.Count;
            //Assert
            Assert.AreNotEqual(initialCount, result);
        }
        [TestMethod]
        public void Test_AddCostEvents()
        {
            //Arrange
            List<Outing> localList = repo.GetListOfOutings();
            SeedOutings();
            decimal testSum;
            decimal expectedSum;
            //Act
            expectedSum = 89.70m*45 + 220.50m*180 + 145.65m*36;
            testSum = repo.AddCostEvents();
            //Assert
            Assert.AreEqual(expectedSum, testSum);
        }
        [TestMethod]
        public void Test_CostByCategory()
        {
            //Arrange
            SeedOutings();
            decimal expectedSum;
            decimal testSum;
            //Act
            expectedSum = 45 * 89.70m;
            testSum = repo.CostByCategory(EventType.Bowling);
            //Assert
            Assert.AreEqual(expectedSum, testSum);
        }
        private void SeedOutings()
        {
            Outing bowlingTournament = new Outing(EventType.Bowling, 45, new DateTime(2020, 05, 15), 89.70m);
            Outing dayAtCedarPoint = new Outing(EventType.AmusementPark, 180, new DateTime(2020, 06, 02), 220.50m);
            Outing valentinesConcert = new Outing(EventType.Concert, 36, new DateTime(2020, 02, 14), 145.65m);

            repo.AddOuting(bowlingTournament);
            repo.AddOuting(dayAtCedarPoint);
            repo.AddOuting(valentinesConcert);
        }
    }
}
