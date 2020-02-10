using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursProject
{
    class Fleet
    {

        //member variables
        public List<Robot> robots;
        public Random random;

        //constructor
        public Fleet()
        {
            random = new Random();
            CreateFleet();
            
        }

        //member methods

        public void CreateFleet()
        {
            Robot robot1 = new Robot("Optimus Prime", random);
            Robot robot2 = new Robot("Bumblebee", random);
            Robot robot3 = new Robot("Johnny 5", random);
           robots = new List<Robot>();
            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);
            

        }


    }
}
