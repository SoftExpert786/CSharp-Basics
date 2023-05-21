using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms.OOPProgram.Interfce
{
    internal interface IShape

    {
        public  void Area() ;
        public void Perimeter() ;
    }
    class ISquare : IShape
    {
        private double _Length;
        
        public void GetDemonsional(double Length)
        {
            _Length = Length;
           

        }
        public void Area()
        {
            double area = _Length * _Length;
            Console.WriteLine("Area of Square is {0}",area);

        }
        public void Perimeter()
        {
            double perimeter = 4 * _Length;
            Console.WriteLine("Perimeter of Square is {0}",perimeter);

        }

    }
    class IRectangle : IShape
    {
        private double _Length;
        private double _Width;

        public void GetDemonsional(double Length,double Width)
        {
            _Length = Length;
            _Width = Width;

        }
        public  void Area()
        {
            double area = _Length * _Width;
            Console.WriteLine("Area of Rectangle is {0}", area);

        }
        public void Perimeter()
        {
            double perimeter = 2 * _Length + 2 * _Width  ;
            Console.WriteLine("Perimeter of Rectangle is {0}", perimeter);

        }

    }
    class ICircle : IShape
    {
        private double _Radius;
        private const double PI = 3.14;

        public void GetDemonsional(double Radius)
        {
            _Radius = Radius;


        }
        public void Area()
        {
            double area = PI * _Radius * _Radius;
            Console.WriteLine("Area of Circle is {0}", area);

        }
        public void Perimeter()
        {
            double perimeter = 2 * PI * _Radius;
            Console.WriteLine("Perimeter of Circle is {0}", perimeter);

        }

    }
    class shape : IRectangle 
    {


    }
}
