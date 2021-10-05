using System;
namespace Generics
{
    public class Food : IStorable
    {
        public string Name { get; set; }

        public Food(string name)
        {
            Name = name;
        }
    }
}
