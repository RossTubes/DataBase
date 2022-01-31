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
        int aantalVoertuigen;
        

        public void Start()
        {
            Console.WriteLine("Go to garage or Leave or status");
            Anwser1 = Console.ReadLine();

            if (Anwser1.ToLower() == "go to garage")
            {
                Parking();
            }

            if (Anwser1.ToLower() == "status")
            {
                Console.WriteLine(aantalVoertuigen);
                Start();
            }

            if (Anwser1.ToLower() == "Leave")
            {
                Console.Clear();
            }
        }

        public void opvragen()
        {
            Console.WriteLine("int amount Cars");
            Anwser2 = Console.ReadLine();
        }

        public void Parking()
        {
            Console.WriteLine("Is it a Car or Motor");
            Anwser1 = Console.ReadLine();
            if (Anwser1.ToLower() == "car")
            {
                Voertuigen aAuto = new Auto(Anwser1);
                garage.AddVoertuigen(aAuto);
                Console.WriteLine("Car parked inside of the garage!");
                aantalVoertuigen++;
                if(aantalVoertuigen <= 10)
                {
                    Start();
                }

                else
                {
                    Console.WriteLine("Garage is full");
                    Start();
                }
                    
            }

            else if (Anwser1.ToLower() == "motor")
            {
                Voertuigen aMotor = new Motors(Anwser1);
                garage.AddVoertuigen(aMotor);
                Console.WriteLine("Motor parked inside of the garage!");
                aantalVoertuigen++;
                if (aantalVoertuigen <= 10)
                {
                    Start();
                }

                else
                {
                    Console.WriteLine("Garage is full");
                    Start();
                }

            }
            //Voertuigen aAuto = new Auto(Anwser1);
            //garage.AddVoertuigen(aAuto);
        }


        public void Stop()
        {
            //keep empty
        }
    }
}
