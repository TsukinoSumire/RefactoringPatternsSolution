using System;

namespace PatternsLibrary.Behavioral.Command
{
    //логика для получателей
    public class Receiver
    { 
        public void DoSomething(string act)
        {
            Console.WriteLine("Reciever. Working on {0}",act);
        }

        public void AlsoDoSomething(string act)
        {
            Console.WriteLine("Reciever. Also working on {0}", act);
        }
    }
}
