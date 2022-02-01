using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    abstract class Voertuigen
    {
        private String name;
        public int ID;
        public Voertuigen(string CarName)
        {
            name = CarName;
        }
        public string GetName()
        {
            return name;
        }
    }
}
