using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        //Member Variables
        // HAS a fleet of robots and a herd of dinosaurs
        public Fleet fleet;
        public Herd herd;

        //Constructor

        public Battlefield()
        {
            this.fleet = new Fleet();
            this.herd = new Herd();

        }


        //Member Methods 

        //public void StartBattle(Fleet fleet, Herd herd)
        //{
        //    while (true)
        //    {
        //        if (GetBattleResult(fleet, herd)) == ("Dinosaurs win!" || "Robots Win");
        //        {
        //            Console.WriteLine("Game Over!");
        //            break;
        //        }
        //    }
                
        //}
        public void GetBattleResults(Fleet fleet, Herd herd)
        {
            for (int i = 0; i < fleet.robots.Count; i++)
            {
                for (int j = 0; j < herd.dinosaurs.Count; j++)
                {
                    herd.dinosaurs[j].AttacksRobot(fleet.robots[i]);
                    if (fleet.robots[i].health <= 0)
                    {
                        i++;
                    }
                    else if (fleet.robots[i].health > 0)
                    {
                        fleet.robots[i].AttacksDinosaur(herd.dinosaurs[j]);
                    }
                    if (herd.dinosaurs[j].health <= 0)
                    {
                        j++;
                    }
                    
                    if (i++ > fleet.robots.Count)
                    {
                        Console.WriteLine("Game Over! Dinosaurs win!");
                    }
                    else if (j++ > herd.dinosaurs.Count)
                    {
                        Console.WriteLine("Game Over! Robots Win"); 
                    }
                }
            }
            
        }


        // when all of the robots or dinos in the fleet/heard health = 0 the game is over 

        // StartBattle 
        // heard, fleet
        // loop giving each robot/dino a chance to attack
        // all die

        // GetAttackResult 
        // pass in herd/fleet
        // calculate one dinos/robots attack 
        // others health
        // subtract attack from health

        // print ou who attacked who and for how much damage 
        // provide output in change in heath

        // check if health falls below zero
        // if so print message and then send response that will end the loop

        // LIST OUT BATTLE STEPS IN PLAIN ENGLISH
    }
}
