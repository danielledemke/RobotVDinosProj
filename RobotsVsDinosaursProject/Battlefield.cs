using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursProject
{
    class Battlefield
    {
        //member variables
        Herd herd;
        Fleet fleet; 

        //constructor
        public Battlefield()
        {
            Console.WriteLine("Welcome to Robots vs Dinosaurs! You choose which dinosaurs to spawn in attempt to defeat the robots!");
            herd = new Herd();
            fleet = new Fleet();
            RepeatAttackRounds();
            AnnounceGameWinner();
        }

        //member methods

        public void AttackOneFullRound()
        {
            Console.WriteLine("Attack round is starting");
            herd.dinos[0].AttackRobot(fleet.robots[0]);
            fleet.robots[0].AttackDino(herd.dinos[0]);
            herd.dinos[1].AttackRobot(fleet.robots[1]);
            fleet.robots[0].AttackDino(herd.dinos[0]);
            herd.dinos[2].AttackRobot(fleet.robots[2]);
            fleet.robots[2].AttackDino(herd.dinos[2]);

        }

        public void GiveTotalStats()
        {
            Console.WriteLine("Here is the round recap:\n");
            Console.WriteLine(herd.dinos[0].type + " has " + herd.dinos[0].health + " health points and " + herd.dinos[0].energy + " energy points");
            Console.WriteLine(herd.dinos[1].type + " has " + herd.dinos[1].health + " health and " + herd.dinos[1].energy + " energy points");
            Console.WriteLine(herd.dinos[2].type + " has " + herd.dinos[2].health + " health points and " + herd.dinos[2].energy + " energy points");
            Console.WriteLine(fleet.robots[0].name + " has " + fleet.robots[0].health + " health points and " + fleet.robots[0].powerLevel + " power level");
            Console.WriteLine(fleet.robots[1].name + " has " + fleet.robots[1].health + " health points and " + fleet.robots[1].powerLevel + " power level");
            Console.WriteLine(fleet.robots[2].name + " has " + fleet.robots[2].health + " health points and " + fleet.robots[2].powerLevel + " power level");
        }

        public void RepeatAttackRounds()
        {
            while(herd.dinos[0].health + herd.dinos[1].health + herd.dinos[2].health > 0 || fleet.robots[0].health + fleet.robots[1].health + fleet.robots[2].health > 0)
            {
                AttackOneFullRound();
                GiveTotalStats();
            }
            
        }

        public void AnnounceGameWinner()
        {
            if(herd.dinos[0].health + herd.dinos[1].health + herd.dinos[2].health > 0)
            {
                Console.WriteLine("The dinos have defeated the robots! WOOT!");
            }
            else if (fleet.robots[0].health + fleet.robots[1].health + fleet.robots[2].health > 0)
            {
                Console.WriteLine("Oh no! You have been defeated by the robots!" );
            }
        }






    }
}
    


        
    

       
 
    
    


  



