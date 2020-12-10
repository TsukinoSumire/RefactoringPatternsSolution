using System;
using System.Collections.Generic;

namespace PatternsLibrary.Behavioral.Observer
{
    public class Subject : ISubject
    {
        IList<IObserver> _observers = new List<IObserver>();

        public int State { get; set; } = -0;

        // Методы управления подпиской.
        public void Add(IObserver observer)
        {
            Console.WriteLine("Add observer.");
            _observers.Add(observer);
        }

        public void Delete(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Remove observer.");
        }

        public void Notify()
        {
            Console.WriteLine("Notify observers");

            foreach (var observer in _observers)
                observer.Update(this);           
        }

        /// <summary>
        /// Логика подписки для издателя
        /// </summary>
        public void SomeBusinessLogic()
        {
            Console.WriteLine("SomeBusinessLogic");
            State = new Random().Next(0, 20);

            /*logic*/

            Console.WriteLine("New State is: " + State);
            Notify();
        }
    }
}
