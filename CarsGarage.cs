using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{ 
    internal class Garage
    {
        public List<Voertuigen> voertuigen;
        public int voertuigeningarage;

        public Garage()
        {
            voertuigen = new List<Voertuigen>();
        }

        public void AddVoertuigen(Voertuigen aVoertuigen)
        {
          voertuigen.Add(aVoertuigen);
        }

        public List<Voertuigen> GetGarage()
        {
            return voertuigen;
        }

        
    }
}

   /* internal class CarsGarage
    {
        private string name;

        public CarsGarage(string aName)
        {
            name = aName;
        }
        public string GetName()
        {
            return name;
        }
    }*/