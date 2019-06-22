using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYZ_to_RGB_COM_Console_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            uint illuminant = 1;
            uint observer = 2;
            sbyte chromaticAdaptation = 0;
            long rgb;
            ushort R;
            ushort G;
            ushort B;

            DATACOLOR_COLORITE_XYZ_TO_RGBLib.__XYZ_coordinate xyzCoord = new DATACOLOR_COLORITE_XYZ_TO_RGBLib.__XYZ_coordinate();

            xyzCoord.X = 1f;
            xyzCoord.Y = 2f;
            xyzCoord.Z = 3f;


            DATACOLOR_COLORITE_XYZ_TO_RGBLib.XYZ_to_RGBClass xyz = new DATACOLOR_COLORITE_XYZ_TO_RGBLib.XYZ_to_RGBClass();

            rgb = xyz.Colorite_qualified_XYZ_to_RGB(xyzCoord.X, xyzCoord.Y, xyzCoord.Z, illuminant, observer, chromaticAdaptation, out R, out G, out B);
            Console.WriteLine("Red: {0}, Green {1}, Blue {2}", R.ToString(), G.ToString(), B.ToString());
            Console.ReadLine();

        }
    }
}
