using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_1
{
    class Apple : IFruit
    {
        string _name;
        double _price;

        public Apple()
        {
            _name = "Mela";
            _price = 0.25;
        }

        public string GetName()
        {
            return this._name;
        }
        public double GetPrice()
        {
            return this._price;
        }
    }
}
