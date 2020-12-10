using System;

namespace PatternsLibrary.Behavioral.Observer
{
    public class Test
    {
        public Test()
        {
            var subject = new Subject();
            var observ1 = new Observer1();
            subject.Add(observ1);

            var observ2 = new Observer2();
            subject.Add(observ2);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Delete(observ2);

            subject.SomeBusinessLogic();

            var observ3 = new Observer3();
            subject.Add(observ3);
            subject.SomeBusinessLogic();
        }


        class Observer1 : IObserver
        {
            public void Update(ISubject subject)
            {
                var state = GetState(subject);
                if (state > 10) Console.WriteLine("Observer1 react");
            }
        }

        class Observer2 : IObserver
        {
            public void Update(ISubject subject)
            {
                var state = GetState(subject);
                if (state > 5) Console.WriteLine("Observer2 react");
            }
        }

        class Observer3 : IObserver
        {
            public void Update(ISubject subject) 
                => Console.WriteLine("Observer3 react");
        }

        public static int GetState(ISubject subject) => (subject as Subject).State;        

    }
}
