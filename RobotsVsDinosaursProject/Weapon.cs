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
        public Random weaponIndice;
        public Weapon[] arrayOfWeapons;
        public Weapon axe;
        public Weapon laserGun;
        public Weapon rocketLauncher;
        public int weaponChoice;
       

        //constructor
        public Weapon(Random random)
        {
            weaponIndice = random;
         AssignRandomWeapon();

        }
        //member methods
        public int RandomizeWeaponChoice()
        {
            arrayOfWeapons = new Weapon[3];
            arrayOfWeapons[0] = axe;
            arrayOfWeapons[1] = laserGun;
            arrayOfWeapons[2] = rocketLauncher;
            return weaponIndice.Next(0, 3);
        }

        public void AssignRandomWeapon()
        {
          weaponChoice = RandomizeWeaponChoice();
            
            if(weaponChoice == 0)
            {
                attackValue = 20;
                type = "Axe";
            }
            else if(weaponChoice == 1)
            {
                attackValue = 30;
                type = "Laser Gun";
            }
            else if(weaponChoice == 2)
            {
                attackValue = 50;
                type = "Rocket Launcher";
            }
        }

        //public void AssignWeapon()
        //{
        //    Console.WriteLine("Enter weapon type to give to Robot: Axe, Laser Gun, or Rocket Launcher \n");
        //    type = Console.ReadLine();
        //    switch (type)
        //    {
        //        case "Axe":
        //        case "axe":
        //        case "ax":
        //            attackValue = 15;
        //            break;
        //        case "Laser Gun":
        //        case "laser gun":
        //        case "laser":
        //            attackValue = 30;
        //            break;
        //        case "Rocket Launcher":
        //        case "rocket launcher":
        //        case "rocket":
        //            attackValue = 50;
        //            break;
        //        default:
        //            Console.WriteLine("Not valid entry");
        //            break;

        //    }
        //}
    }
}
