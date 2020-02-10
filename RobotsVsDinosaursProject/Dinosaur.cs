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
           Console.WriteLine("A " + type + " dinosaur has been spawned");
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
                        break;
                }
            }
            while (type == null);
            
        }
        public int AttackRobot(Robot robot)
        {
            robot.health -= attackPower;
            energy -= 10;
            return robot.health;
        }
    }
}
