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
        public int AttacksDinosaur(List<Weapon> weapons, List<Robot> robots)
        {
            int attack = 0;
            foreach (var robot in robots)
            {
                attack += robot.weapon.attackPower;
            }
            return attack;
        }
        public int NewRobotHealthAfterAttacked(Dinosaur dinosaur)
        {  
            health -= dinosaur.attackPower++;
            return health;
        }
            


    }
}
