﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_NET
{
    public class Toyota : Car
    {
        public override void SpeedUp()
        {
            if (status != 0)
            {
                if (speed < 300)
                {
                    if (speed + 35 > 400)
                    { 
                        speed = 400;
                        status = 2;
                    }
                    status = 2;
                    speed = speed + 35;
                    Console.WriteLine("Скорость машины: " + speed);
                }
                else
                {
                    speed = 300;
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
