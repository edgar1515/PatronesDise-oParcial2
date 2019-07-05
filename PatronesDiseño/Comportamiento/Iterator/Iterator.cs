﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Iterator : IAbstractIterator
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;

        //Constructor
        public Iterator(Collection collection)
        {
            this._collection = collection;
        }

        //Obtener el primer item
        public Item First()
        {
            _current = 0;
            return _collection[_current] as Item;
        }

        //Obtener siguiente item
        public Item Next()
        {
            _current += _step;
            if (!IsDone)
                return _collection[_current] as Item;
            else
                return null;
        }

        // Obtiene o establece el tamaño de la escalera
        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        // Obtiene el elemento iterador actual
        public Item CurrentItem
        {
            get { return _collection[_current] as Item; }
        }

        // Obtiene si la iteración es completa
        public bool IsDone
        {
            get { return _current >= _collection.Count; } 
        }
    }
}
