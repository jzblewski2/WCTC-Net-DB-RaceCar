using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RaceTrack.RaceTrack.Cars
{
    public class FordFusion : RaceCar
    {
        public FordFusion()
        {
            Name = "Ford Fusion";
            TopSpeed = 70;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} motor turned over");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} screeches their brakes!");
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} engine cuts off!");
        }
    }
}
