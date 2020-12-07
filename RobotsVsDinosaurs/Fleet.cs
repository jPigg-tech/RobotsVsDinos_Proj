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
        public List<Weapon> weapons;

        //Constructor

        public Fleet()
        {
            robots = new List<Robot>();
            weapons = new List<Weapon>();

            Weapon dinoSplitter = new Weapon("sword", 20);
            Weapon cannon = new Weapon("cannon", 15);
            Weapon handGun = new Weapon("pistol", 10);

            Robot ironGiant = new Robot("Bender", dinoSplitter);
            Robot tank = new Robot("Bull Dod", cannon);
            Robot roboCop = new Robot("Gordon Gecko", handGun);

            PopulateFleet(ironGiant);
            PopulateFleet(tank);
            PopulateFleet(roboCop);

            PopulateWeaponInventory(dinoSplitter);
            PopulateWeaponInventory(cannon);
            PopulateWeaponInventory(handGun);
        }

        //Member Methods 
        public void PopulateFleet(Robot robot)
        {
            robots.Add(robot);
        }
        public void PopulateWeaponInventory(Weapon weapon)
        {
            weapons.Add(weapon);
        }

    }
}
