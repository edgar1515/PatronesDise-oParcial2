﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Customers : CustomersBase
    {
        public Customers(string group)

      : base(group)

        {

        }



        public override void ShowAll()

        {

            // Add separator lines

            Console.WriteLine();

            Console.WriteLine("------------------------");

            base.ShowAll();

            Console.WriteLine("------------------------");

        }
       

        }
    abstract class DataObject

    {

        public abstract void NextRecord();

        public abstract void PriorRecord();

        public abstract void AddRecord(string name);

        public abstract void DeleteRecord(string name);

        public abstract void ShowRecord();

        public abstract void ShowAllRecords();
    }
}
