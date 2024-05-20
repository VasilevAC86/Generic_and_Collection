using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Generic_and_Collection
{
    public struct Sword: IWeapon
    {        
        public string Type() { return "Меч"; }
        public int Power {  get; set; }
        public string Quality { get; set; }
        public string Special() { return "Меч рубит"; }
        public Sword(int power, string Q) 
        {
            this.Power = power;
            this.Quality = Q;
        }
    }
}
