using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            MathProxy proxy = new MathProxy();



            // Haz las matematicas

            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));

            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));

            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));

            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));



            // Esperando usuario

            Console.ReadKey();
        }
    }
    public interface IMath

    {

        double Add(double x, double y);

        double Sub(double x, double y);

        double Mul(double x, double y);

        double Div(double x, double y);

    }
}
