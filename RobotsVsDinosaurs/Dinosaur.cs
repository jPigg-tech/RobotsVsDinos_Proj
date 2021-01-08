using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Dinosaur
    {
        //Member Variables
        public string type;
        public int health;
        public int energyPercentage;
        public DinoAttack dinoAttack;


        //Constructor
        public Dinosaur(string type, DinoAttack dinoAttack)
        {
            this.type = type;
            this.dinoAttack = dinoAttack;
            health = 100;
            energyPercentage = 100;
        }


        //Member Methods 
        public int AttacksRobot(Robot robot)
        {
            robot.health -= dinoAttack.attackPower;
            energyPercentage -= 10;
            return robot.health;
        }

    }
}
