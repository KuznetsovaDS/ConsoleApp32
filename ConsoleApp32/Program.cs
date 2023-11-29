using System;
using System.ComponentModel.Design;

namespace Triangle
{
    class Triangle : IComparable<Triangle>
    {
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }
        private double d { get; set; }


        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        
        public Triangle(double D)
        {
            d = D;
        }

        public double Square()
        {          
          double p = (a + b + c) / 2;
          return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
         }
        public double Square1()
        {
          return Math.Sqrt(d * d * d * d * 3 / 16);
        }


        public int CompareTo(Triangle other)
        {
            return this.Square().CompareTo(other.Square());
            
        }
        public int CompareTo1(Triangle other)
        {
            return this.Square1().CompareTo(other.Square1());
        }

        public void Show()
        {
            Console.WriteLine($"Треугольник со сторонами a = {a}, b = {b}, c = {c}");
        }
        public void Show1()
        {
            Console.WriteLine($"Треугольник со стороной d = {d}");
        }
       }

    class Program
    {
        static void Main()
        {
            Triangle t1 = new Triangle(3, 4, 5);
            Triangle t2 = new Triangle(10, 12, 14);
            Triangle t3 = new Triangle(11, 14, 17);
            Triangle t4 = new Triangle(100, 95, 44);
            Triangle t5 = new Triangle(1, 1, 3);
            Triangle t6 = new Triangle(2, 6, 8);

            Triangle[] triangles = { t1, t2, t3, t4, t5, t6 };

            Console.WriteLine("Разносторонние реугольники до сортировки");
            foreach (var triangle in triangles)
            {
                triangle.Show();
            }

            Array.Sort(triangles);

            Console.WriteLine("\nРазносторонние треугольники отсортированы по площади");
            foreach (var triangle in triangles)
            {
                triangle.Show();
            }
            double d;
            Triangle t = new Triangle(d = 10);
            Console.WriteLine("\nРавносторонний треугольник:");
            Console.WriteLine("\nПлощадь = " + t.Square1());
            t.Show1();

        }
    }
}