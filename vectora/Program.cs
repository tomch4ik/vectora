using System.Numerics;
using System.Runtime.Intrinsics;

namespace vectora
{
    public struct Vectors
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Vectors(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static Vectors operator *(Vectors vector, double number)
        {
            return new Vectors(vector.X * number, vector.Y * number, vector.Z * number);
        }
        public static Vectors operator +(Vectors v1, Vectors v2)
        {
            return new Vectors(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }
        public static Vectors operator -(Vectors v1, Vectors v2)
        {
            return new Vectors(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }
        public override string ToString()
        {
            return $"Vector({X}, {Y}, {Z})";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vectors v1 = new Vectors(1.0, 2.0, 3.0);
            Vectors v2 = new Vectors(3.0, 2.0, 1.0);
            Vectors multiplied = v1 * 3;
            Console.WriteLine("Умножение на число: " + multiplied);
            Vectors sum = v1 + v2;
            Console.WriteLine("Добавление векторов: " + sum);
            Vectors difference = v1 - v2;
            Console.WriteLine("Отнимание векторов: " + difference);
        }
    }
}
