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
        public List<Robot> robots = new List<Robot>();

        //constructor
        public Fleet()
        {
            CreateFleet();

        }

        //member methods

        public void CreateFleet()
        {
            Robot robot1 = new Robot("Optimus Prime");
            Robot robot2 = new Robot("Bumblebee");
            Robot robot3 = new Robot("Johnny 5");
            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);
            

        }


    }
}
