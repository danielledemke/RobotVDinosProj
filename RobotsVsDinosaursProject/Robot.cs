using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursProject
{
    class Robot
    {
        //member variables
        public string name = "";
        public int health;
        public int powerLevel;
        public int attackPower;
        public Weapon weapon = new Weapon();



        //constructor
        public Robot()
        {
            weapon.GrabWeapon();
        }

        //member methods


    }

}
