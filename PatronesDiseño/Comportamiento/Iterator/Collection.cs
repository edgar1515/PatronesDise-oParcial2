using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Collection : IAbstractCollection
    {
        private ArrayList _items = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        //Obtener el recuento de elementos
        public int Count
        {
            get { return _items.Count; }
        }

        //Indexador
        public object this [int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }

    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
}
