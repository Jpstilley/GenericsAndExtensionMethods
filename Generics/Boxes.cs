using System;
namespace Generics
{
    public class Boxes : IStorable
    {
        public string Name { get; set; }

        public Boxes(string name)
        {
            Name = name;
        }
    }
}
