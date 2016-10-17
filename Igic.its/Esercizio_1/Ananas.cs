using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_1
{
    class Ananas : IFruit
    {
        string _name;
        double _price;

        public Ananas()
        {
            _name = "Ananas";
            _price = 1.20;
        }
        
        public string GetName()
        {
            return this._name;
        }

        public double GetPrice()
        {
            return this. _price;
        }
    }
}
