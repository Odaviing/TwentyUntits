using System;
using Xunit;

namespace TwentyUnits
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double diametr = 5;
            Assert.Equal(15.7, Math.Round(CircleFormulas.GetCircumferenceThroughDiametr(diametr), 1));
        }

        
        
        [Fact]
        public void Test2()
        {
            double radius = 5;
            Assert.Equal(31.4, Math.Round(CircleFormulas.GetCircumferenceThroughRadius(radius), 1));
        }

        [Fact]
        public void Test3()
        {
            double diametr = 5;
            Assert.Equal(19.6, Math.Round(CircleFormulas.GetSquareThroughDiametr(diametr), 1));
        }

        [Fact]
        public void Test4()
        {
            double radius = 5;
            Assert.Equal(78.5, Math.Round(CircleFormulas.GetSquareThroughRadius(radius), 1));
        }

        [Fact]
        public void Test5()
        {
            double radius = 5;
            Assert.Equal(10, Math.Round(CircleFormulas.GetDiametr(radius), 1));
        }

        [Fact]
        public void Test6()
        {
            double radius = 5;
            double centerAngleSinus = 0.5;
            Assert.Equal(2.5, Math.Round(CircleFormulas.GetChordThroughRadiusAndCenterAngle(radius, centerAngleSinus), 1));
        }

        [Fact]
        public void Test7()
        {
            double radius = 5;
            double incribedAngleSinus = 0.5;
            Assert.Equal(5, Math.Round(CircleFormulas.GetChordThroughRadiusAndInscribedAngle(radius, incribedAngleSinus), 1));
        }

        [Fact]
        public void Test8()
        {
            double centerAngle = 30;
            Assert.Equal(15, Math.Round(CircleFormulas.GetInscribedAngle(centerAngle), 1));
        }

        [Fact]
        public void Test9()
        {
            double radius = 5;
            double centerAngle = 30;
            Assert.Equal(2.6, Math.Round(CircleFormulas.GetArcLengthThroughCenterAngle(radius, centerAngle), 1));
        }

        [Fact]
        public void Test10()
        {
            double radius = 5;
            double centerAngle = 30;
            Assert.Equal(6.5, Math.Round(CircleFormulas.GetSectorSquareThroughCenterAngle(radius, centerAngle), 1));
        }

        [Fact]
        public void Test11()
        {
            double firstBase = 5;
            double secondBase = 5;
            Assert.Equal(5, Math.Round(TrapezoidFormulas.GetMiddleLine(firstBase, secondBase), 1));
        }

        [Fact]
        public void Test12()
        {
            double middleLine = 5;
            double secondBase = 5;
            Assert.Equal(5, Math.Round(TrapezoidFormulas.GetBaseThroughMiddleLineAndSecondBase(middleLine, secondBase), 1));
        }

        [Fact]
        public void Test13()
        {
            double height = 5;
            double bottomAngleSinus = 0.5;
            Assert.Equal(10, Math.Round(TrapezoidFormulas.GetSideThroughHeightAndBottomAngle(height, bottomAngleSinus), 1));
        }

        [Fact]
        public void Test14()
        {
            double height = 5;
            double square = 20;
            Assert.Equal(4, Math.Round(TrapezoidFormulas.GetMiddleLineThroughHeightAndSquare(height, square), 1));
        }

        [Fact]
        public void Test15()
        {
            double firstBase = 5;
            double secondBase = 10;
            double square = 30;
            Assert.Equal(4, Math.Round(TrapezoidFormulas.GetHeightThroughSquareAndBases(square, firstBase, secondBase), 1));
        }

        [Fact]
        public void Test16()
        {
            double middleLine = 5.5;
            double square = 30;
            Assert.Equal(5.5, Math.Round(TrapezoidFormulas.GetHeightThroughMiddleAndSquare(middleLine, square), 1));
        }

        [Fact]
        public void Test17()
        {
            double firstBase = 5;
            double secondBase = 10;
            double height = 3;
            Assert.Equal(22.5, Math.Round(TrapezoidFormulas.GetSquareThroughBasesAndHeight(firstBase, secondBase, height), 1));
        }

        [Fact]
        public void Test18()
        {
            double middleLine = 5.2;
            double height = 3.3;
            Assert.Equal(17.2, Math.Round(TrapezoidFormulas.GetSquareThroughMiddleAndHeight(middleLine, height), 1));
        }

        [Fact]
        public void Test19()
        {
            double a = 5.2;
            double b = 3.3;
            double c = 4.6;
            double d = 2.1;
            Assert.Equal(15.2, Math.Round(TrapezoidFormulas.GetPerimetr(a, b, c, d), 1));
        }

        [Fact]
        public void Test20()
        {
            double height = 8.6;
            Assert.Equal(4.3, Math.Round(TrapezoidFormulas.GetInscribedCircleRadius(height), 1));
        }

        
        
        [Fact]
        public void Test21()
        {
            double a = 8.6;
            double b = 10.2;
            Assert.Equal(18.8, Math.Round(TrapezoidFormulas.LetsCheckThisOut(a, b), 1));
        }
    }
}
