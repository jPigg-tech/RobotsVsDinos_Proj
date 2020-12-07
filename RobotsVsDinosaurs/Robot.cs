using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Robot
    {
        //Member Variables
        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;


        //Constructor
        public Robot(string name, Weapon weapon)
        {
            this.name = name;
            this.weapon = weapon;
            health = 100;
            powerLevel = 100;
        }


        //Member Methods 
        public Robot CreateNewRobot(string name, Weapon weapon)
        {
            Robot robot = new Robot(name, weapon);

            return robot;
        }

    }
}
