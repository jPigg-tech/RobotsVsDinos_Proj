using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Fleet
    {
        //Member Variables
        public List<Robot> robots;
        public Weapon dinoSplitter;
        public Weapon cannon;
        public Weapon handgun;

        //Constructor

        public Fleet()
        {
            robots = new List<Robot>();
            Weapon dinoSplitter = new Weapon("sword", 20);
            Weapon cannon = new Weapon("cannon", 15);
            Weapon handGun = new Weapon("pistol", 10);

            Robot ironGiant = new Robot("Bender", dinoSplitter);
            Robot tank = new Robot("Bull Dod", cannon);
            Robot roboCop = new Robot("Gordon Gecko", handGun);
        }

        

        //Member Methods 
        public void PopulateFleet(Robot robot)
        {
            robots.Add(robot);
        }

    }
}
