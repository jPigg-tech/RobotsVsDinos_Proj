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
        public int robotScore;
        public int dinosaurScore;

        //Constructor

        public Battlefield()
        {
            this.fleet = new Fleet();
            this.herd = new Herd();
            robotScore = 0;
            dinosaurScore = 0;
        }

        //Member Methods        
        public void StartBattle()
        {
            // while robotScore or dinosaur score is <= 3
            // if robot 0 and dinosaur 0 are still alive, they should fight again
            // if robot health = 0 or dinosaur health = 0, robotScore += 1
            // declare winner

            for (int i = 0; i < fleet.robots.Count; i++)
            {
                for (int j = 0; j < herd.dinosaurs.Count; j++)
                {
                    while (fleet.robots[i].health > 0 && herd.dinosaurs[j].health > 0)
                    {
                        fleet.robots[i].AttacksDinosaur(herd.dinosaurs[j]);

                        if (herd.dinosaurs[j].health <= 0)
                        {
                            Console.WriteLine("The robot wins this round!");
                            herd.dinosaurs.Remove(herd.dinosaurs[j]);
                            j++;
                            robotScore++;
                        }
                        else
                        {
                            Console.WriteLine("The Dinosaurs new health is " + herd.dinosaurs[j].health);
                        }

                        herd.dinosaurs[j].AttacksRobot(fleet.robots[i]);

                        if (fleet.robots[i].health <= 0)
                        {
                            Console.WriteLine("The Dinosaur wins this round!");
                            fleet.robots.Remove(fleet.robots[i]);
                            i++;
                            dinosaurScore++;
                        }
                        else
                        {
                            Console.WriteLine("The Robots new health is " + fleet.robots[i].health);
                        }
                    }
                }             
                // end while loop, next iteration
            }
        }
        public void GetBattleResults()
        {
            if (robotScore > dinosaurScore)
            {
                Console.WriteLine("The Robots have won the battle!");
            }
            else
            {
                Console.WriteLine("The Dinosaurs have won the battle!");
            }
        }

        //for (int i = 0; i < fleet.robots.Count; i++)
        //{
        //    for (int j = 0; j < herd.dinosaurs.Count; j++)
        //    {
        //        herd.dinosaurs[j].AttacksRobot(fleet.robots[i]);
        //        if (fleet.robots[i].health <= 0)
        //        {
        //            i++;
        //        }
        //        else if (fleet.robots[i].health > 0)
        //        {
        //            fleet.robots[i].AttacksDinosaur(herd.dinosaurs[j]);
        //        }
        //        if (herd.dinosaurs[j].health <= 0)
        //        {
        //            j++;
        //        }

        //        if (i++ > fleet.robots.Count)
        //        {
        //            Console.WriteLine("Game Over! Dinosaurs win!");
        //            Console.ReadLine();
        //        }
        //        else if (j++ > herd.dinosaurs.Count)
        //        {
        //            Console.WriteLine("Game Over! Robots Win");
        //            Console.ReadLine();
        //        }
        //    }
        //}

    


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
