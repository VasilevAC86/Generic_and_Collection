using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_and_Collection
{
    public class Person<T> where T : IWeapon
    {
        public string Name { get; set; }
        public string Species { get; set; }
        private T IWeapon { get; set; }
        public void Info()
        {
            Console.WriteLine("Имя = " + Name + "\nРаса = " + Species);
        }
        public Person(string name, string species, T weapon)
        {
            Name = name;
            Species = species;
            IWeapon = weapon;
        }
    }
}
