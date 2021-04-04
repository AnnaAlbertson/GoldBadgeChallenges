﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Challenge2_Repository;
using System.Collections.Generic;

namespace Challenge2_UnitTests
{
    [TestClass]
    public class Claims_RepoTesting
    {
        private Claims_Repo repo = new Claims_Repo();
        
        [TestMethod]
        public void Test_GetClaimsList()
        {
            //Arrange
            SeedClaimQueue();
            //Act
            Queue<Claims> localList = repo.GetClaimsQueue();
            //Assert
            Assert.AreEqual(3, localList.Count);
        }
        [TestMethod]
        public void Test_UpdateClaims()
        {
        }
        [TestMethod]
        public void Test_DeleteClaims()
        {
        }
        [TestMethod]
        public void Test_CreateClaim()
        {

        }
        private void SeedClaimQueue()
        {
            // Seeding Queue
            Claims claim1 = new Claims(1, ClaimType.Car, "Car accident on 465.", 400.00m, new DateTime(2018, 04, 25), new DateTime(2018, 04, 11));
            Claims claim2 = new Claims(2, ClaimType.Home, "House fire in kitchen.", 4000.00m, new DateTime(2018, 04, 11), new DateTime(2018, 04, 12));
            Claims claim3 = new Claims(3, ClaimType.Theft, "Stolen pancakes.", 4.00m, new DateTime(2018, 04, 27), new DateTime(2018, 06, 1));

            // Adding to Queue
            repo.EnquequeClaim(claim1);
            repo.EnquequeClaim(claim2);
            repo.EnquequeClaim(claim3);
        }
    }
}
