using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_and_Collection
{
    public struct Bow:IWeapon
    {
        public string Type() { return "Меч"; }
        public int Power { get; set; }
        public int Distance { get; set; } // Дальность
        public int Accuracy { get; set; } // Точность
        public string Special() { return "Лук стреляет"; }
    }
}
