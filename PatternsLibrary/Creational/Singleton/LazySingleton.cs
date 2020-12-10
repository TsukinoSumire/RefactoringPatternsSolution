using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsLibrary.Creational.Singleton
{
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());

        public static LazySingleton Instance => _instance.Value;

        LazySingleton() { }         
    }
}