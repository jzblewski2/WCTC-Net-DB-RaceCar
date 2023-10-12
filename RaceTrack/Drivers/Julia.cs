using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Julia : Driver
    {
        public Julia(RaceCar car) : base(car)
        {
            Name = "Julia";
            SkillLevel = 7;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
