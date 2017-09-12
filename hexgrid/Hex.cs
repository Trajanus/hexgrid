using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hexgrid
{
    public class Hex
    {
        private int pixelRadius;
        public Hex(int radius)
        {
            pixelRadius = radius;
        }

        public int GetWidth()
        {
            return pixelRadius * 2;
        }
    }
}
