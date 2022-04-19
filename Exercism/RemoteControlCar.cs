using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    class RemoteControlCar
    {
        public int Speed { get; set; }
        public int BatteryDrain { get; set; }
        public int DistanceDriven { get; set; }
        public int BatteryPercentage { get; set; }

        public RemoteControlCar(int speed, int batteryDrain)
        {
            Speed = speed;
            BatteryDrain = batteryDrain;
            BatteryPercentage = 100;
        }

        public bool BatteryDrained() => BatteryPercentage == 0;
        
        public void Drive()
        {
            if (!BatteryDrained())
            {
                DistanceDriven += Speed;
                BatteryPercentage -= BatteryDrain;
                if (BatteryPercentage < BatteryDrain) BatteryPercentage = 0;

            }
            else
                Console.WriteLine("Can no longer drive, battery is drained.");
        }

        public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
    }  
}
