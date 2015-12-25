using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
                Normalize();
            }
        }

        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if(value != 0)
                {
                    denominator = value;
                    Normalize();
                }
                else
                {
                    throw new ArgumentException("Denominator cannot be 0");
                }
            }
        }

        public Fraction(int numerator, int denominator)
        {
            if (denominator != 0)
            {
                this.numerator = numerator;
                this.denominator = denominator;
                Normalize();
            }
            else
            {
                throw new ArgumentException("Denominator cannot be 0");
            }
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", Numerator, Denominator);
        }

        public override bool Equals(object obj)
        {
            var other = obj as Fraction;
            if(other != null)
            {
                return Numerator == other.Numerator
                    && Denominator == other.Denominator;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Numerator.GetHashCode();
                hash = hash * 23 + Denominator.GetHashCode();
                return hash;
            }
        }

        #region Operators
        public static bool operator ==(Fraction first, Fraction second)
        {
            return object.Equals(first, second);
        }

        public static bool operator !=(Fraction first, Fraction second)
        {
            return !(first == second);
        }

        public static Fraction operator +(Fraction first, Fraction second)
        {
            return new Fraction(first.Numerator * second.Denominator + second.Numerator * first.Denominator, first.Denominator * second.Denominator);
        }

        public static Fraction operator -(Fraction first, Fraction second)
        {
            return new Fraction(first.Numerator * second.Denominator - second.Numerator * first.Denominator, first.Denominator * second.Denominator);
        }

        public static Fraction operator *(Fraction first, Fraction second)
        {
            return new Fraction(first.Numerator * second.Numerator, first.Denominator * second.Denominator);
        }

        public static Fraction operator /(Fraction first, Fraction second)
        {
            return new Fraction(first.Numerator * second.Denominator, first.Denominator * second.Numerator);
        }

        public static explicit operator double(Fraction other)
        {
            return (double)other.Numerator / other.Denominator;
        }

        public static double operator +(Fraction first, double second)
        {
            return (double)first + second;
        }

        public static double operator -(Fraction first, double second)
        {
            return (double)first - second;
        }

        public static double operator *(Fraction first, double second)
        {
            return (double)first * second;
        }

        public static double operator /(Fraction first, double second)
        {
            return (double)first / second;
        }

        public static double operator +(double first, Fraction second)
        {
            return first + (double)second;
        }

        public static double operator -(double first, Fraction second)
        {
            return first - (double)second;
        }

        public static double operator *(double first, Fraction second)
        {
            return first * (double)second;
        }

        public static double operator /(double first, Fraction second)
        {
            return first / (double)second;
        }
        #endregion

        private void Normalize()
        {
            var gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;

            if(denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
        }

        private int GCD(int x, int y)
        {
            while (y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }
            return x;
        }
    }
}
