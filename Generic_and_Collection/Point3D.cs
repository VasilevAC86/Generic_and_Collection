using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_and_Collection
{
    public class Point3D:Point2D<int> // Наследник с конкретной реализацией int
    {
        public int Z {  get; set; }
        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        public override string ToString()
        {
            return $"x = {X}, y = {Y}, z = {Z}";
        }
    }
}
