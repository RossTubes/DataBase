using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    class Functies
    {
        string Anwser1;
        string Anwser2;
        string Anwser3;
        Garage garage = new Garage();
        int aantalVoertuigen;
        int aantalMotors;
        int aantalAuto;
        int aantalGroundLevel;
        int aantalLevelOne;

        public void Start()
        {
            Console.WriteLine("Go to garage or Leave or status");
            Anwser1 = Console.ReadLine();

            if (Anwser1.ToLower() == "go to garage")
            {
                ParkingLevel();
            }

            if (Anwser1.ToLower() == "status")
            {
                Console.WriteLine("choose motor or car status or total");
                string Anwser2 = Console.ReadLine();

                if (Anwser2.ToLower() == "motor")
                {
                    Console.WriteLine(aantalMotors + ". Motors" );
                    Start();
                }
                if (Anwser2.ToLower() == "car")
                {
                    Console.WriteLine(aantalAuto + ". Cars");
                    Start();
                }
                if (Anwser2.ToLower() == "total")
                {
                Console.WriteLine(aantalVoertuigen + ". voertuigen");
                Console.WriteLine(aantalAuto + ". Cars");
                Console.WriteLine(aantalGroundLevel + ". vehicles GroundLevel");
                Console.WriteLine(aantalLevelOne + ". vehicles levelOne");
                Start();
                }

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

        public void ParkingLevel()
        {
            Console.WriteLine("You wanna park on groundLevel or level one?");
            Anwser1 = Console.ReadLine();

            if (Anwser1.ToLower() == "groundlevel")
            {
                Console.WriteLine("vehicle moved to groundLevel");
                if (aantalVoertuigen <= 5)
                {
                    aantalGroundLevel++;
                    Parking();
                }
                else
                {
                    Console.WriteLine("Garage is full");
                    Start();
                }
            }
            if (Anwser1.ToLower() == "level one")
            {
                Console.WriteLine("vehicle moved to LevelOne");
                if (aantalVoertuigen <= 5)
                {
                    aantalLevelOne++;
                    Parking();
                }
                else
                {
                    Console.WriteLine("Garage is full");
                    Start();
                }
            }
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
                aantalAuto++;
                if(aantalVoertuigen <= 5)
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
                aantalMotors++;
                if (aantalVoertuigen <= 5)
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
