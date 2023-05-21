using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace FindSquareUsingInheritance
{
    

        public  abstract class Shape
        {
            public  abstract void Area();
            public  abstract void Perimeter();




        }
        class  Square : Shape
        {
            private double Length;


            public void GetDemonsion(double _length)
            {
                Length = _length;

            }
            public override void Area()
            {
                Console.WriteLine("Area of Square are {0}", Length * Length);
            }

            public override void Perimeter()
            {

                Console.WriteLine("Perimeter of Square are {0}", 4 * Length);

            }
        }
        class Rectanguler : Shape
        {
            private double Length;
            private double Width;

            public void GetDemonsion(double _length, double _width)
            {
                Length = _length;
                Width = _width;
            }
            public override void Area()
            {
                Console.WriteLine("Area of Rectangular are {0}", Length * Width);
            }

            public override void Perimeter()
            {

                Console.WriteLine("Perimeter of Rectangular are {0}", 2 * Length + 2 * Width);

            }
        }
        class  Circle : Shape
        {
            private const double Pi = 3.14;
            private double Radius;

            public void GetDemonsion(double _Radius)
            {
                Radius = _Radius;
            }
            public sealed override void Area()
            {
                Console.WriteLine("Area of Circle are {0}", Pi * Radius * Radius);
            }

            public sealed override void Perimeter()
            {

                Console.WriteLine("Perimeter of Circle are {0}", 2 * Pi * Radius);

            }
        }
        class main
        {
            static void Main(String[] args)
            {
                Circle shape = new Circle();
                shape.GetDemonsion(4.5);
                shape.Area();
                shape.Perimeter();
                Rectanguler shape1 = new Rectanguler();
                shape1.GetDemonsion(4.5,4.6);
                shape1.Area();
                shape1.Perimeter();
                Square shape2 = new Square();
                shape2.GetDemonsion(4.5);
                shape2.Area();
                shape2.Perimeter();

            }
        }
    }
