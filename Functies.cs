using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    class Functies
    {
        string Anwser1;
        string Anwser2;
        Garage garage = new Garage();

        public void Start()
        {
            Console.WriteLine("Go to garage or Leave or status");
            Anwser1 = Console.ReadLine();

        }

        public void opvragen()
        {
            Console.WriteLine();
        }

        public void Parking()
        {
            Console.WriteLine("Is it a Car or Motor");
            Voertuigen aAuto = new Auto(Anwser1);
            garage.AddVoertuigen(aAuto);
        }


        public void Stop()
        {
            //keep empty
        }
    }
}
