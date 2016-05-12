using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorTruck
{
    class Vector2
    {
        double x, y;
        double magnitude;

        Vector2 unit;

        public Vector2(double dX, double dY)
        {
            x = dX;
            y = dY;

            magnitude = Math.Sqrt(dX * dX + dY * dY);

            if (magnitude != 1)
            {
                unit = new Vector2(dX / magnitude, dY / magnitude);
            }
            else
            {
                unit = this;
            }

        }

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;                
            }
        }
        
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public double Magnitude
        {
            get
            {
                return magnitude;
            }
        }

        public Vector2 Unit
        {
            get
            {
                return unit;
            }
        }

        public Vector2 RotateVector(double AngleInRadians)
        {
            double rX, rY;

            double sinA = Math.Sin(AngleInRadians);
            double cosA = Math.Cos(AngleInRadians);

            rX = x * cosA - y * sinA;
            rY = x * sinA + y * cosA;

            return new Vector2(rX, rY);
        }

        #region Operators

        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector2 operator *(double d, Vector2 v)
        {
            return new Vector2(v.X * d, v.Y * d);
        }

        public static Vector2 operator *(Vector2 v, double d)
        {
            return new Vector2(v.X * d, v.Y * d);
        }

        public static double operator *(Vector2 v1, Vector2 v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }

        #endregion

        public string ToString()
        {
            return x.ToString() + ", " + y.ToString();
        }

    }
}
