using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Worley", "Inside ASP.NET", 10);

            book.Display();



            // Crear video

            Video video = new Video("Spielberg", "Jaws", 23, 92);

            video.Display();



            // Hacer que el video sea prestable, luego tomar prestado y mostrarlo

            Console.WriteLine("\nMaking video borrowable:");



            Borrowable borrowvideo = new Borrowable(video);

            borrowvideo.BorrowItem("Customer #1");

            borrowvideo.BorrowItem("Customer #2");



            borrowvideo.Display();



            // Esperando usuario

            Console.ReadKey();
        }
    }
    abstract class LibraryItem

    {

        private int _numCopies;



        // Propiedad

        public int NumCopies

        {

            get { return _numCopies; }

            set { _numCopies = value; }

        }



        public abstract void Display();

    }
}
