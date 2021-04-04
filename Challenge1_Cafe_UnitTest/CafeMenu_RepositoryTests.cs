using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Challenge1_Cafe_Repository;
using System.Collections.Generic;

namespace Challenge1_Cafe_UnitTest
{
    [TestClass]
    public class CafeMenu_RepositoryTests
    {
        private CafeMenu_Repository repo = new CafeMenu_Repository();

        [TestMethod]
        public void TestMethod_GetCafeMenuList()
        {
            // Arrange - I didn't really feel like I needed it here
            //Act
            List<CafeMenu> localList = repo.GetCafeMenuList();

            //Assert
            Assert.IsNotNull(localList);
        }

        [TestMethod]
        public void TestMethod_AddMenuItem()
        {
            //Arrange
            CafeMenu menuItem = new CafeMenu();
            List<CafeMenu> localList = repo.GetCafeMenuList();

            //Act
            int initialCount = localList.Count;
            repo.AddMenuItem(menuItem);
            int actual = localList.Count;
            int expected = initialCount+1;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod_ReadMenuItems()
        {
            //Arrange

            //Act

            //Assert

        }

        [TestMethod]
        public void TestMethod_DeleteMenuItem()
        {
            //Arrange

            //Act

            //Assert

        }

        [TestMethod]
        public void TestMethod_GetMenuItemByMealNumber()
        {
            //Arrange

            //Act

            //Assert

        }
    }
}
