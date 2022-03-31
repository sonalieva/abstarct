using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Car:Vehicle
    {
        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }
        public int FuelFor { get; set; }
        public override void Drive(int km)
        {
            if(km * FuelFor < CurrentFuel)
            {
                CurrentFuel = CurrentFuel - (km * FuelFor);
                Millage = Millage + km;
            }
             static Car [] FilMil(Car[] cars,int min,int max)
            {
                Car []newcar = new Car[0];
                for(int i = 0; i < cars.Length; i++)
                {
                    if(cars[i].Millage>min && cars[i].Millage < max)
                    {
                        Array.Resize(ref newcar, newcar.Length + 1);
                        newcar[newcar.Length - 1] = cars[i];
                    }
                }
                return newcar;
            }
        }

           
    }
}
