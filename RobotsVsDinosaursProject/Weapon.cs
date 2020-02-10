using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursProject
{
    class Weapon
    {

        //member variables
        public string type = "";
        public int attackValue;

        //constructor
        public Weapon()
        {
           
         AssignWeapon();

        }
        //member methods

        public void AssignWeapon()
        {
            Console.WriteLine("Enter weapon type: Axe, Laser Gun, or Rocket Launcher \n");
            type = Console.ReadLine();
            switch (type)
            {
                case "Axe":
                case "axe":
                case "ax":
                    attackValue = 15;
                    break;
                case "Laser Gun":
                case "laser gun":
                case "laser":
                    attackValue = 30;
                    break;
                case "Rocket Launcher":
                case "rocket launcher":
                case "rocket":
                    attackValue = 50;
                    break;
                default:
                    Console.WriteLine("Not valid entry");
                    break;

            }
        }
    }
}
