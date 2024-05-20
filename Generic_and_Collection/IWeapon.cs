using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_and_Collection
{
    public interface IWeapon
    {
        static string Type_ { get; set; }
        public int Power { get; set; }
        public string Special();
    }
}
