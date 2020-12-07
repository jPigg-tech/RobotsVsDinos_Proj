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
        public int attackPower;


        //Constructor
        public Dinosaur(string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;
            health = 100;
            energyPercentage = 100;
        }


        //Member Methods 
        public int AttacksRobot(List<Dinosaur> dinosaurs)
        {
            int attack = 0;
            foreach(var dinosaur in dinosaurs)
            {
                attack += dinosaur.attackPower;
            }
                attackPower = attack;
                return attackPower;
        }
        public int NewDinoHealthAfterAttacked(Robot robot)
        {
            health -= robot.weapon.attackPower++;
            return health;
        }

    }
}
