using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa car sayini daxil edin");
            int count = Convert.ToInt32(Console.ReadLine());
            Car[] car = new Car[count];
            Car car1 = new Car();
            
            for(int i = 0; i < car.Length; i++)
            {
                Console.WriteLine("Zehmet olmasa coloru daxil edin");
                string color = Console.ReadLine();
                Console.WriteLine(" Zehmet olmasa brandi daxil edin");
                string brand = Console.ReadLine();
                Console.WriteLine("Zehmet olmasa millage ni daxil edin ");
                int millage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zehmet olmasa fuelcapacity ni daxil edin ");
                int fuelcapacity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zehmet olmasa currentfuel i daxil edin");
                int currentfuel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zehmet olmasa fuelfor u daxil edin");
                int fuelfor = Convert.ToInt32(Console.ReadLine());
                car1 = new Car();
                
                car1.Drive(3);

            }
            bool check = true;
            while (check)
            {
                Console.WriteLine("1-Masinlari millage ye gore filterle\n2-Butun masinlari goster\n3-Prossesi bitir");
                string answer = Console.ReadLine();
                if(answer == "1")
                {
                    Console.WriteLine("Zehmet olmasA Max ve Min deyerleri daxil edin");
                    int min = Convert.ToInt32(Console.ReadLine());
                    int max = Convert.ToInt32(Console.ReadLine());
                    foreach(var item in car.FilMil(car,min,max))
                    {
                        Console.WriteLine(item.ShowInfo);
                    }
                }
                else if(answer == "2")
                {
                    foreach(var item in car)
                    {
                        Console.WriteLine(item.ShowInfo());
                    }
                }
                else  if(answer == "3") {
                    Console.WriteLine("Stop");
                }
                        

                

            }

        }
    }
}
