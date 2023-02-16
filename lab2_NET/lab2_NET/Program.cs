using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("a - завести машину\nb - заглушить машину\nc - ускорение\nd - тормоз\ne - вкл. радио\nf - выкл. радио\n");
            Console.WriteLine("Выберите машину:\n1.Toyota\n2.Ferrari\n3.Bugatti\n");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Вы выбрали Toyota!\n");
                    Toyota toyota = new Toyota();
                    while (!endApp)
                    {
                        switch (Console.ReadLine())
                        {
                            case "a":
                                toyota.Start();
                                break;
                            case "b":
                                toyota.Stop();
                                break;
                            case "c":
                                toyota.SpeedUp();
                                break;
                            case "d":
                                toyota.SpeedDown();
                                break;
                            case "e":
                                toyota.On();
                                break; 
                            case "f":
                                toyota.Off();
                                break;
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine("Вы выбрали Ferrari!\n");
                    Ferrari ferrari = new Ferrari();
                    while (!endApp)
                    {
                        switch (Console.ReadLine())
                        {
                            case "a":
                                ferrari.Start();
                                break;
                            case "b":
                                ferrari.Stop();
                                break;
                            case "c":
                                ferrari.SpeedUp();
                                break;
                            case "d":
                                ferrari.SpeedDown();
                                break;
                            case "e":
                                ferrari.On();
                                break;
                            case "f":
                                ferrari.Off();
                                break;
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("Вы выбрали Bugatti!\n");
                    Bugatti bugatti = new Bugatti();
                    while (!endApp)
                    {
                        switch (Console.ReadLine())
                        {
                            case "a":
                                bugatti.Start();
                                break;
                            case "b":
                                bugatti.Stop();
                                break;
                            case "c":
                                bugatti.SpeedUp();
                                break;
                            case "d":
                                bugatti.SpeedDown();
                                break;
                            case "e":
                                bugatti.On();
                                break;
                            case "f":
                                bugatti.Off();
                                break;
                        }
                    }
                    break;

            }
        }
    }
}
