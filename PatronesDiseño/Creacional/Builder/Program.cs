﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();



            Builder b1 = new ConcreteBuilder1();

            Builder b2 = new ConcreteBuilder2();



            // Constructor dos productos

            director.Construct(b1);

            Product p1 = b1.GetResult();

            p1.Show();



            director.Construct(b2);

            Product p2 = b2.GetResult();

            p2.Show();



            // Esperando a usar

            Console.ReadKey();
        }
    }
}
