using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_NET
{
    abstract public class Car : Radio 
    {
        public int speed = 0;
        public int status = 0;
        public int radio = 0;

        int accelerate = 20;

        public void Start()
        {
            if (status == 0)
            {
                status = 1;
                Console.WriteLine("Машина заведена");
            }
        }
        public void Stop()
        {
            if (status == 1)
            {
                status = 0;
                Console.WriteLine("Машина заглушена");
            }

        }
        abstract public void SpeedUp();
        
        public void SpeedDown()
        {
            if (status == 2)
            {
                speed = speed - 30;
                if (speed <= 0)
                {
                    status = 1;
                    speed = 0;
                    Console.WriteLine("Скорость машины: " + speed);
                }
                else
                {
                    Console.WriteLine("Скорость машины: " + speed);
                }
            }
        }
        
    }
    




}
