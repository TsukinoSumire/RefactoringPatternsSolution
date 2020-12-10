using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsLibrary.Creational.Singleton
{
    public class DoubleLockSingleton
    {
        private static volatile DoubleLockSingleton _instance;
        private static readonly object _lockObj;

        public static DoubleLockSingleton Instance
        {
            get
            {
                CreateInstance();
                return _instance;
            }
        }

        DoubleLockSingleton() { }

        private static void CreateInstance()
        {
            if(_instance == null)
            {
                lock(_lockObj)
                {
                    if(_instance == null)
                    {
                        _instance = new DoubleLockSingleton();
                    }
                }
            }
        }

    }
}
