using System.Reflection.Metadata.Ecma335;

namespace Homework_5
{
    public class Figure
    {
        public double a;
        public double b;
        public double c;
    }

    #region Triangle
    public class Triangle : Figure
    {
        public double h;
        public double R;
        public double r;
        public int angle;


        public double GetAreaBaseAndHeight()
        {
            return a * h / 2;
        }

        public double GetAreaByHerons()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double GetAreaByTwoSidesAndAngle()
        {
            return a * b * Math.Sin(angle) / 2;
        }

        public double GetAreaByThreeSidesAndRadius()
        {
            return a * b * c / 4 * R;
        }

        public double GetAreaBySemiPerimeterAndRadius(double p, double r)
        {
            return p * r;
        }

        public double GetPerimeter()
        {
            return a + b + c;
        }
    }
    #endregion

    #region Square
    public class Square : Figure
    {
        public double diagonal;

        public double GetAreaByBase()
        {
            return Math.Pow(a, 2);
        }

        public double GetAreaByDiagonal()
        {
            return Math.Pow(diagonal, 2) / 2;
        }

        public double GetPerimeterByBase()
        {
            return 4 * a;
        }

        public double GetPerimeterByDiagonal()
        {
            return 2 * Math.Sqrt(2) * diagonal;
        }
    }
    #endregion

    #region Rectangle
    public class Rectangle : Figure
    {
        public double h;
        public double GetArea()
        {
            return a * b;
        }
        public double GetPerimeter()
        {
            return 2 * (a + b);
        }
    }
    #endregion

    #region Rhombus
    public class Rhombus : Figure
    {
        public double h;
        public int angle;
        public double firstDiagonal;
        public double secondDiagonal;

        public double GetAreaBySideAndHeight()
        {
            return a * h;
        }
        public double GetAreaBySideAndAngle()
        {
            return Math.Pow(a, 2) * Math.Sign(angle);
        }
        public double GetAreaByDiagonals()
        {
            return firstDiagonal * secondDiagonal / 2;
        }
        public double GetPerimeter()
        {
            return 4 * a;
        }
    }
    #endregion

    #region Parallelogram
    public class Parallelogram : Figure
    {

        public double h;
        public int angle;
        public double firstDiagonal;
        public double secondDiagonal;

        public double GetAreaBySideAndHeight()
        {
            return a * h;
        }
        public double GetAreaByTwoSidesAndAngle()
        {
            return a * b * Math.Sin(angle);
        }
        public double GetAreaByDiagonalsAndAngle()
        {
            return firstDiagonal * secondDiagonal * Math.Sin(angle) / 2;
        }
        public double GetPerimeter()
        {
            return (a + b) * 2;
        }

    }
    #endregion

    #region Trapeze
    public class Trapeze : Figure
    {

        public double h;
        public double d;

        public double GetAreaByTwoSidesAndHeight()
        {
            return (a + b) * h / 2;
        }
        public double GetAreaByHerons()
        {
            double p = (a + b + c + d) / 2;
            return ((a + b) / Math.Abs(a - b)) * Math.Sqrt((p - a) * (p - b) * (p - a - c) * (p - a - d));
        }
        public double GetPerimeter()
        {
            return a + b + c + d;
        }

    }
    #endregion

    #region Quadrangle
    public class Quadrangle : Figure
    {
        public double d;
        public double r;
        public int firstAngle;
        public int secondAngle;
        public double firstDiagonal;
        public double secondDiagonal;

        public double GetAreaByDiagonalsAndAngle()
        {
            return firstDiagonal * secondDiagonal * Math.Sin(firstAngle) / 2;
        }
        public double GetAreaBySemiPerimeterAndRadius()
        {
            double p = (a + b + c + d) / 2;
            return p * r;
        }
        public double GetAreaByFourSidesAndTwoAngles()
        {
            double p = (a + b + c + d) / 2;
            return Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d) - a * b * c * d * Math.Pow(Math.Cos((firstAngle + secondAngle) / 2), 2));
        }
        public double GetAreaByFourSides()
        {
            double p = (a + b + c + d) / 2;
            return Math.Sqrt((p - a) * (p - b) * (p - c) * (p - d));
        }
        public double GetPerimeter()
        {
            return a + b + c + d;
        }
    }
    #endregion

    #region Circle
    public class Circle
    {
        public double r;
        public double d;
        public double GetArea()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public double GetAreaByDiameter()
        {
            return Math.PI * Math.Pow(d, 2) / 4;
        }
        public double GetLength()
        {
            return 2 * Math.PI * r;
        }
        public double GetLengthByDiameter()
        {
            return Math.PI * d;
        }
    }
    #endregion

    #region Volume
    public sealed class Cube : Square
    {
        public double s;
        public double GetVolume()
        {
            return s * a;
        }
    }

    public sealed class Prism : Triangle
    {
        public double s;

        public double GetVolume()
        {
            return s * h;
        }
    }

    public sealed class Parallelepiped : Rectangle
    {
        public double s;
        public double GetVolume()
        {
            return s * h;
        }
    }

    public sealed class Cylinder : Circle
    {
        public double h;
        public double s;

        public double GetVolume()
        {
            return s * h;
        }

    }

    public sealed class Cone : Circle
    {
        public double h;
        public double s;

        public double GetVolume()
        {
            return s * h / 3;
        }
    }

    public sealed class Ball : Circle
    {
        public double GetVolume()
        {
            return 4 * Math.PI * Math.Pow(r, 3) / 3;
        }
    }
    #endregion

}
