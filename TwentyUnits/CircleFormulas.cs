using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyUnits
{
    public class CircleFormulas
    {
        public static double GetCircumferenceThroughDiametr (double diametr)
        {
            return diametr * 3.14;
        }

        public static double GetCircumferenceThroughRadius(double radius)
        {
            return radius * 2 * 3.14;
        }

        public static double GetSquareThroughDiametr(double diametr)
        {
            return (Math.Pow(diametr, 2) * 3.14) / 4;
        }

        public static double GetSquareThroughRadius(double radius)
        {
            return Math.Pow(radius, 2) * 3.14;
        }

        public static double GetDiametr(double radius)
        {
            return radius * 2;
        }

        public static double GetChordThroughRadiusAndCenterAngle(double radius, double centerAngleSinus)
        {
            return 2 * radius * centerAngleSinus / 2;
        }

        public static double GetChordThroughRadiusAndInscribedAngle(double radius, double inscribedAngleSinus)
        {
            return 2 * radius * inscribedAngleSinus;
        }

        public static double GetInscribedAngle(double centerAngle)
        {
            return centerAngle / 2;
        }

        public static double GetArcLengthThroughCenterAngle(double radius, double centerAngle)
        {
            return ((3.14 * radius) / 180) * centerAngle;
        }

        
        
        
        
        public static double GetSectorSquareThroughCenterAngle(double radius, double centerAngle)
        {
            return ((3.14 * Math.Pow(radius, 2)) / 360) * centerAngle;
        }


    }
}
