using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_Spiral_WFA
{
    class Point3D : Point2D, ICsvFormattable
    {
        public Point3D()
        {
        }

        public Point3D(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public float Z { get; set; }
        public void ToCsvString(string filename, List<Point3D> listXYZ)
        {
            StringBuilder csvcontent = new StringBuilder();
            var dateString2 = DateTime.Now.ToString("yyyy-MM-dd");
            csvcontent.AppendLine("x,y,z");

            foreach (var xyz in listXYZ) {
                csvcontent.AppendLine(xyz.X.ToString().Replace(',', '.') + ", " 
                    + xyz.Y.ToString().Replace(',', '.') + ", " 
                    + xyz.Z.ToString().Replace(',', '.'));
            }
            string dir = @"C:\CSVdata\";

            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string csvpath = dir + filename + dateString2 + ".csv";
            File.AppendAllText(csvpath, csvcontent.ToString());
        }
    }
}
