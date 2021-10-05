using System;
using System.Collections.Generic;

namespace Generics
{
    public class Storage<T> where T : IStorable
    {
        public List<T> Bin { get; set; } = new List<T>();


        public Storage(params T[] bin)
        {
            Array.ForEach(bin, item => Bin.Add(item));
        }

         
    }
}
