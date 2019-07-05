using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsability
{
    class Purchase
    {
        private int _number;
        private double _amount;
        private string _purpose;

        //Constructor
        public Purchase (int number, double amount, string purpose)
        {
            this._number = number;
            this._amount = amount;
            this._purpose = purpose;
        }

        //Obtiene o establece el número de compra
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        //Obtiene o establece el monto de la compra
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        //Obtiene o establece el propósito de compra
        public string Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }
    }
}
