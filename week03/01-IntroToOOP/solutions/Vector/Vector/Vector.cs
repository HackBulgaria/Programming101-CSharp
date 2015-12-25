using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    public class Vector
    {
        private List<double> coordinates;

        public int Dimension
        {
            get
            {
                return coordinates.Count;
            }
        }

        public double this[int index]
        {
            get
            {
                return coordinates[index];
            }
            set
            {
                coordinates[index] = value;
            }
        }

        public Vector(params double[] coordinates)
        {
            this.coordinates = new List<double>(coordinates);
        }

        public Vector(Vector other)
        {
            coordinates = new List<double>(other.coordinates);
        }

        public double GetLength()
        {
            double sum = 0;
            foreach(var coord in coordinates)
            {
                sum += coord * coord;
            }

            return Math.Sqrt(sum);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("(");
            for(int i = 0; i < coordinates.Count; i++)
            {
                result.Append(coordinates[i]);
                if(i < coordinates.Count - 1)
                {
                    result.Append(", ");
                }
            }
            result.Append(")");

            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            var other = obj as Vector;
            if (other != null && coordinates.Count == other.coordinates.Count)
            {
                for (int i = 0; i < coordinates.Count; i++)
                {
                    if(coordinates[i] != other.coordinates[i])
                    {
                        return false;
                    }
                }

                return true;
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
                for (int i = 0; i < coordinates.Count; i++)
                {
                    hash = hash * 23 + coordinates[i].GetHashCode();
                }
                return hash;
            }
        }

        #region Operators
        public static bool operator ==(Vector first, Vector second)
        {
            return object.Equals(first, second);
        }

        public static bool operator !=(Vector first, Vector second)
        {
            return !(first == second);
        }

        public static Vector operator +(Vector first, Vector second)
        {
            if (first.coordinates.Count == second.coordinates.Count)
            {
                var coordinates = new double[first.coordinates.Count];
                for (int i = 0; i < coordinates.Length; i++)
                {
                    coordinates[i] = first.coordinates[i] + second.coordinates[i];
                }

                return new Vector(coordinates);
            }
            else
            {
                throw new ArgumentException("The 2 vectors must have the same dimensionality");
            }
        }

        public static Vector operator -(Vector first, Vector second)
        {
            if (first.coordinates.Count == second.coordinates.Count)
            {
                var coordinates = new double[first.coordinates.Count];
                for (int i = 0; i < coordinates.Length; i++)
                {
                    coordinates[i] = first.coordinates[i] - second.coordinates[i];
                }

                return new Vector(coordinates);
            }
            else
            {
                throw new ArgumentException("The 2 vectors must have the same dimensionality");
            }
        }

        public static Vector operator *(Vector first, double second)
        {
            var coordinates = new double[first.coordinates.Count];
            for (int i = 0; i < coordinates.Length; i++)
            {
                coordinates[i] = first.coordinates[i] * second;
            }

            return new Vector(coordinates);
        }

        public static Vector operator *(double first, Vector second)
        {
            var coordinates = new double[second.coordinates.Count];
            for (int i = 0; i < coordinates.Length; i++)
            {
                coordinates[i] = first * second.coordinates[i];
            }

            return new Vector(coordinates);
        }

        public static Vector operator /(Vector first, double second)
        {
            var coordinates = new double[first.coordinates.Count];
            for (int i = 0; i < coordinates.Length; i++)
            {
                coordinates[i] = first.coordinates[i] / second;
            }

            return new Vector(coordinates);
        }

        public static double operator *(Vector first, Vector second)
        {
            if (first.coordinates.Count == second.coordinates.Count)
            {
                double sum = 0;
                for (int i = 0; i < first.coordinates.Count; i++)
                {
                    sum += first.coordinates[i] * second.coordinates[i];
                }

                return sum;
            }
            else
            {
                throw new ArgumentException("The 2 vectors must have the same dimensionality");
            }
        }
        #endregion
    }
}
