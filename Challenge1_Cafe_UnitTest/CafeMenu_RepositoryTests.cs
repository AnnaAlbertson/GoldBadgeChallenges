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
        public void TestMethod_AddMenuItem()
        {
            //Arrange
            CafeMenu menuItem = new CafeMenu();
            List<CafeMenu> localList = repo.ReadMenuItems();

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
            // Arrange - I didn't really feel like I needed it here
            //Act
            List<CafeMenu> localList = repo.ReadMenuItems();

            //Assert
            Assert.IsNotNull(localList);
        }

        [TestMethod]
        public void TestMethod_DeleteMenuItem()
        {
            //Arrange
            SeedCafeMenuList();
            int removableItemNumber = 1;
            int failingItemNumber = 25;
            bool trueTest, falseTest;
            //Act
            trueTest = repo.DeleteMenuItem(removableItemNumber);
            falseTest = repo.DeleteMenuItem(failingItemNumber);

            //Assert
            Assert.IsTrue(trueTest);
            Assert.IsFalse(falseTest);

        }

        [TestMethod]
        public void TestMethod_GetMenuItemByMealNumber()
        {
            //Arrange
            SeedCafeMenuList();
            int existingMealNumber = 2;
            int fakeMealNumber = 56;
            CafeMenu notNullTest, nullTest;
            //Act
            notNullTest = repo.GetMenuItemByMealNumber(existingMealNumber);
            nullTest = repo.GetMenuItemByMealNumber(fakeMealNumber);

            //Assert
            Assert.IsNotNull(notNullTest);
            Assert.IsNull(nullTest);
        }
        private void SeedCafeMenuList()
        {
            CafeMenu menuItemOne = new CafeMenu(1, "Spinach Feta Omelette Cups",
                "An order of delectable baked eggs in the form of muffin bottoms\n" +
                "with all the great flavors of a perfectly cooked omelette filled\n" +
                "with our signature blend of spices, spinach, and feta.", 9.79m, "eggs, spinach, feta");

            repo.AddMenuItem(menuItemOne);

            CafeMenu menuItemTwo = new CafeMenu(2, "Crab Cake Benedict",
                "Our famous crab cakes on an english muffin topped with a\n" +
                "beautifully poached egg and some house-made hollandaise\n" +
                "sauce served with sauteed spinach and bacon.", 13.89m, "english muffin, crab cakes, " +
                "eggs, hollandaise, spinach, bacon");

            repo.AddMenuItem(menuItemTwo);

            CafeMenu menuItemThree = new CafeMenu(3, "Blueberry Muffins",
                "These perfectly crumbly, decadent muffins with a burst of\n" +
                "blueberry flavor will have you saying 'mmm...mmm... good'\n" +
                "Scratch-made, freshly baked every morning.", 8.99m, "blueberries and muffin mix");

            repo.AddMenuItem(menuItemThree);
        }
    }
}
