using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyUnits
{
    public class TrapezoidFormulas
    {
        public static double GetMiddleLine(double firstBase, double secondBase)
        {
            return (firstBase + secondBase) / 2;
        }

        public static double GetBaseThroughMiddleLineAndSecondBase(double middleLine, double secondBase)
        {
            return (2 * middleLine) - secondBase;
        }

        public static double GetSideThroughHeightAndBottomAngle(double height, double bottomAngleSinus)
        {
            return height / bottomAngleSinus;
        }

        
        
        
        
        
        public static double GetMiddleLineThroughHeightAndSquare(double height, double square)
        {
            return square / height;
        }

        public static double GetHeightThroughSquareAndBases(double square, double firstBase, double secondBase)
        {
            return (2 * square) / (firstBase + secondBase);
        }

        public static double GetHeightThroughMiddleAndSquare(double middleLine, double square)
        {
            return square / middleLine;
        }

        public static double GetSquareThroughBasesAndHeight(double firstBase, double secondBase, double height)
        {
            return ((firstBase + secondBase) / 2) * height;
        }

        public static double GetSquareThroughMiddleAndHeight(double middleLine, double height)
        {
            return middleLine * height;
        }

        public static double GetPerimetr(double a, double b, double c, double d)
        {
            return a + b + c + d;
        }

        public static double GetInscribedCircleRadius(double height)
        {
            return height / 2;
        }

        public static double LetsCheckThisOut(double a, double b)
        {
            return a + b;
        }

        public static double LetsCheckThisOutTheSequel(double a, double b)
        {
            return a - b;
        }
        
        
        
    }
}
