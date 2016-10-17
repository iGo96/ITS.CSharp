using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_1
{
    class Orange : IFruit
    {
        string _name;
        double _price;

        public Orange()
        {
            _name = "Arancia";
            _price = 0.60;
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
