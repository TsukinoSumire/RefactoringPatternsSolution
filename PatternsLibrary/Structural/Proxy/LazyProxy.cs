using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsLibrary.Structural.Proxy
{
    public interface IWeight
    {
        void MemoryEater();
    }

    public class Weight : IWeight
    {
        public void MemoryEater() { }
    }

    class LazyProxy : IWeight
    {
        private readonly Lazy<Weight> _lazy = new Lazy<Weight>();

        public void MemoryEater() => _lazy.Value.MemoryEater(); 
    }
}
