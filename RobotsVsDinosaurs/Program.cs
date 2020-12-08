using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fleet fleet = new Fleet();
            Herd herd = new Herd();

            Battlefield battlefield = new Battlefield();
            battlefield.StartBattle(fleet, herd);
            battlefield.GetBattleResults();

            Console.ReadLine();

        }
    }
}
