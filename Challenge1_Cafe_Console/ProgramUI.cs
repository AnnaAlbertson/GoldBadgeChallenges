using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1_Cafe_Repository;

namespace Challenge1_Cafe_Console
{
    class ProgramUI
    {
        private CafeMenu_Repository _cafeRepo = new CafeMenu_Repository();

        //Run Method to start and run program
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        //Menu method
        private void Menu()
        {

        }

        //Create a cafe menu item
        private void CreateNewMenuItem()
        {

        }

        //Read current cafe menu
        private void ReadCurrentCafeMenu()
        {

        }
        
        //Delete a cafe menu item
        private void RemoveAMenuItem()
        {

        }

        //SeedContentList to prevent starting with an empty list of CafeMenu
        private void SeedContentList()
        {

        }
    }
}
