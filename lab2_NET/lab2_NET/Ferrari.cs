using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab2_NET
{
    public class Ferrari : Car
    {
        public override void SpeedUp()
        {
            if (status != 0)
            {
                if (speed < 350)
                {
                    status = 2;
                    speed = speed + 35;
                    Console.WriteLine("Скорость машины: " + speed);
                }
                else
                {
                    speed = 350;
                    Console.WriteLine("Достигнута максимальная скорость");
                }
            }
            else
            {
                Console.WriteLine("Машина не заведена");
            }

        }
    }
}
