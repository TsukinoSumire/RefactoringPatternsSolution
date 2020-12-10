using PatternsLibrary.Behavioral.Command;
using PatternsLibrary.Creational.Builder;
using PatternsLibrary.Structural.Adapter;
using System;
using Behav = PatternsLibrary.Behavioral;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region test proxy (admin VS)
            //var proxyTest = new PatternsLibrary.Structural.Proxy.ServiceProxy();
            //proxyTest.TestProxy();
            #endregion
            
            //Builder();

            //Adapter();

            // TestBaseCommand();

            // new Behav.Observer.Test();

            TestStringIntern();

            Console.ReadLine();
        }

        static void Builder()
        {
            var dir = new Director();
            var builder = new SpecificBuilder();
            dir.Builder = builder;
            dir.AllBuild();

            Console.WriteLine(builder.GetProduct().ToString());
        }

        static void Adapter()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine(target.GetTarget());
        }

        static void TestBaseCommand()
        {
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("test"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new RecieverCommand(receiver, "Action 1", "Action2"));

            invoker.DoSomethingImportant();
        }

        #region String.Intern()
        static void TestStringIntern()
        {           
            var b = "Bella";
            var bc = "Bella ciao";
            var testStr = b + "ciao";
            Console.WriteLine("{0}, {1}", Object.ReferenceEquals(bc, testStr), bc == testStr); // f t
            testStr = "Bella ciao";
            Console.WriteLine("{0}, {1}", Object.ReferenceEquals(bc, testStr), bc == testStr); // t t

            Console.WriteLine(Object.ReferenceEquals(String.Intern(bc), String.Intern(testStr))); // t
            Console.WriteLine("{0}, {1}, {2}", String.Intern(b), String.Intern(bc), String.Intern(testStr));


            string testStrFromArr = new string(new char[] { 't', 'e', 's', 't' });
            object copyTestStrFromArr = String.Copy(testStrFromArr);
            Console.WriteLine(object.ReferenceEquals(copyTestStrFromArr, testStrFromArr)); // очевидно f
            String.Intern(copyTestStrFromArr.ToString()); // => add ref on copyStr 
            Console.WriteLine(object.ReferenceEquals(copyTestStrFromArr, String.Intern(testStrFromArr))); // t t => Intern(testStrFromArr) return ref copyStr form Intern Pool

            object copy2 = String.Copy(testStrFromArr);
            String.Intern(copy2.ToString()); // ссылка на себя 
            Console.WriteLine(object.ReferenceEquals(copy2, String.Intern(testStrFromArr))); // f => мы тут в пул никаих ссылок не добавляли. тч все еще return ref on copyStr form Intern Pool


            Console.WriteLine("String.IsInterned() test");
            // Returns:
            //     A reference to str if it is in the common language runtime intern pool; otherwise,
            //     null.

            string InternPoolContainsStr(string str) => String.IsInterned(str) ?? "not interned";
            var testCharArr = new char[] { 'q', 'w', 'e' };
            string s = new string(testCharArr);
            Console.WriteLine(InternPoolContainsStr(s)); // =>null
            String.Intern(s);
            Console.WriteLine(InternPoolContainsStr(s)); // => string
            Console.WriteLine(object.ReferenceEquals(
            String.IsInterned(new string(testCharArr)), s)); // true //(1)

            //// V string literal auto add in pool
            //Console.WriteLine(object.ReferenceEquals("qwe", s)); // (1) => false
            // Console.WriteLine(object.ReferenceEquals("q" + "w" + "e", s));// (1) => false (ибо компилятор умный, он сразу соберет жто в строку)
            Console.WriteLine(object.ReferenceEquals(String.Format("{0}{1}{2}", 'x', 'y', 'z'), s));// (1) => true а вот тут в методе, тут при выполенении          
        }
        #endregion

    }
}
