using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_Spiral_WFA
{
    interface ICsvFormattable
    {
        void ToCsvString(string filename, List<Point3D> listXYZ);
    }
}
