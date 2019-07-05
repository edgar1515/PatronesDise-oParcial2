using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear sala de chat

            Chatroom chatroom = new Chatroom();



            // Crea participantes y regístralos.

            Participant George = new Beatle("George");

            Participant Paul = new Beatle("Paul");

            Participant Ringo = new Beatle("Ringo");

            Participant John = new Beatle("John");

            Participant Yoko = new NonBeatle("Yoko");



            chatroom.Register(George);

            chatroom.Register(Paul);

            chatroom.Register(Ringo);

            chatroom.Register(John);

            chatroom.Register(Yoko);



            // participantes en el chat

            Yoko.Send("John", "Hi John!");

            Paul.Send("Ringo", "All you need is love");

            Ringo.Send("George", "My sweet Lord");

            Paul.Send("John", "Can't buy me love");

            John.Send("Yoko", "My sweet love");



            // Esperando a usar

            Console.ReadKey();
        }
    }

    abstract class AbstractChatroom
    {
        public abstract void Register(Participant participant);
        public abstract void Send(
            string from, string to, string message);
    }
}
