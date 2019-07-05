using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customers = new Customers("Chicago");



            // Establecer Implementador de Concreto

            customers.Data = new CustomersData();



            // ejercitar el puente

            customers.Show();

            customers.Next();

            customers.Show();

            customers.Next();

            customers.Show();

            customers.Add("Henry Velasquez");



            customers.ShowAll();



            //Esperando el usuario

            Console.ReadKey();
        }
    }
}
