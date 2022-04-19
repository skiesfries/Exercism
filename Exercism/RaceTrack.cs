using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    class RaceTrack
    {
        private int Distance { get; set; }

        public RaceTrack(int distance)
        {
            Distance = distance;
        }
        public bool TryFinishTrack(RemoteControlCar car)
        {
            while (!car.BatteryDrained())
            {
                car.Drive();
                if (car.DistanceDriven == Distance) return true;
            }
            return false;
        }
    }
}
