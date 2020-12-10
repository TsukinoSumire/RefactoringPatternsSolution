using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsLibrary.Creational.Singleton
{
    public class SimpleSingleton
    {
        private static SimpleSingleton _instance;

        public static SimpleSingleton Instance => _instance ?? (_instance = new SimpleSingleton());

        SimpleSingleton() { }

    }
}
