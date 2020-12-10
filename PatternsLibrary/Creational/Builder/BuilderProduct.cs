using System;
using System.Collections.Generic;

namespace PatternsLibrary.Creational.Builder
{
    public class BuilderProduct
    {
        private List<string> _parts = new List<string>();

        public void Add(string part) => _parts.Add(part);
       
        public override string ToString()
        {
            string partsStr = String.Join(", ", _parts);           

            return $"Product parts: {partsStr}";
        }
    }
}
