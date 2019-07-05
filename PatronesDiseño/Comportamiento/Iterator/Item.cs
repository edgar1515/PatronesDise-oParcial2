using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Item
    {
        private string _name;

        //Constructor
        public Item (string name)
        {
            this._name = name;
        }

        //Obtener nombre
        public string Name
        {
            get { return _name; }
        }
    }

    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
