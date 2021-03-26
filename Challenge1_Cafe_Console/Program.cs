using System;
using Challenge1_Cafe_Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_Cafe_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //new instances of CafeMenu and CafeMenu_Repository to access in the console
            CafeMenu menuItems = new CafeMenu();
            CafeMenu_Repository repo = new CafeMenu_Repository();
        }
    }
}
