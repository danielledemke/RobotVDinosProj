﻿using System;
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
        public Weapon weapon;

        
        //constructor
        public Robot(string name)
        {
            weapon = new Weapon();
            attackPower = weapon.attackValue;
            this.name = name;
            Console.WriteLine(name + " the Robot has spawned into the game with a " + weapon.type);
            powerLevel = 100;
            health = 100;

        }

        //member methods
        public void AttackDino(Dinosaur dino)
        {
            dino.health -= attackPower;
            powerLevel -= 10;
        }

    }

}
