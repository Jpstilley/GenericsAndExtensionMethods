using System;
using System.Collections.Generic;

namespace Generics
{
    public class Storage<T> where T : IStorable
    {
        public List<T> Bin { get; set; }


        public Storage()
        {
            Bin = new List<T>();
        }

         
    }
}
