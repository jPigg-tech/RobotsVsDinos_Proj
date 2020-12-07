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


        //Constructor
        public Herd()
        {
            dinosaurs = new  List<Dinosaur>();
            Dinosaur sharpTooth = new Dinosaur("Tyrannosaurus", 20);
            Dinosaur spike = new Dinosaur("Ankylosaurus", 15);
            Dinosaur topps = new Dinosaur("Triceratops", 10);
            PopulateHeard(sharpTooth);
            PopulateHeard(sharpTooth);
            PopulateHeard(sharpTooth);

        }

        

        //Member Methods 
        public void PopulateHeard(Dinosaur dinosaur)
        {
            dinosaurs.Add(dinosaur);
        }

    }
}   
