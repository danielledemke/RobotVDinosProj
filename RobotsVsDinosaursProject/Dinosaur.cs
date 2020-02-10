using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursProject
{
    class Dinosaur
    {
        //member variables
        public string type = "";
        public int health;
        public int energy;
        public int attackPower;


        //constructor
        public Dinosaur()
        {
            ChooseDinosaur();
           Console.WriteLine("A " + type + " dinosaur has been spawned!");
            health = 100;
            energy = 100;
        }

        //member methods
        public void ChooseDinosaur()
        {

            do
            {
                Console.WriteLine("Please choose type of dinosaur to spawn: TRex, Velociraptor, or Triceratops \n");
                string type = Console.ReadLine();
                this.type = type;
                switch (type)
                {
                    case "TRex":
                    case "trex":
                    case "Trex":
                        attackPower = 50;
                        break;
                    case "Velociraptor":
                    case "velociraptor":
                        attackPower = 30;
                        break;
                    case "Triceratops":
                    case "triceratops":
                        attackPower = 20;
                        break;
                    default:
                        Console.WriteLine("Not a valid entry");
                        ChooseDinosaur();
                        break;
                }
            }
            while (type == null);
            
        }
        public void AttackRobot(Robot robot)
        {
            if (robot.health > 0 && energy > 0 && health > 0)
            {
                robot.health -= attackPower;
                energy -= 10;
            }
            else
            {
                Console.WriteLine(robot.name + " is dead and cannot be attacked");
            }
            
        


        }
    }
}
