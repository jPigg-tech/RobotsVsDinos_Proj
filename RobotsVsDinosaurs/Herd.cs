using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Herd
    {
        //Member Variables
        public List<Dinosaur> dinosaurs;
        public DinoAttack[] dinoAttacks;

        //Constructor
        public Herd()
        {
            dinosaurs = new  List<Dinosaur>();
            dinoAttacks = new DinoAttack[3];

            dinoAttacks[0] = new DinoAttack("bite", 10);
            dinoAttacks[1] = new DinoAttack("scratch", 15);
            dinoAttacks[2] = new DinoAttack("fire blast", 20);
          
            Dinosaur sharpTooth = new Dinosaur("Tyrannosaurus", dinoAttacks[2]);
            Dinosaur spike = new Dinosaur("Ankylosaurus", dinoAttacks[1]);
            Dinosaur topps = new Dinosaur("Triceratops", dinoAttacks[0]);

            PopulateHeard(sharpTooth);
            PopulateHeard(spike);
            PopulateHeard(topps);
        }      

        //Member Methods 
        public void PopulateHeard(Dinosaur dinosaur)
        {
            dinosaurs.Add(dinosaur);
        }

    }
}   
