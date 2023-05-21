using System;
namespace InterfaceCalss
{
    interface IShape
    {
        double Area();
        double Perimeter();
    }
    class Square : IShape 
    {
        
        private double Length;
       
       public void GetArea(double _Length) { Length = _Length; }
        public  double Area()
        {
            return Length * Length ;
        }

        public double Perimeter()
        {
            return 4 * Length;
        }
    }
    class Rectanguler : IShape 
    {
        
        public double Length;
        private double width;
       
       public void GetArea(double _Length ,double Width) { 
           Length = _Length; 
            width = Width;
        }
        public double Area()
        {
            
            return Length*width ;
            

        }

        public double Perimeter()
        {
            
            return (2 * Length + 2 * width);
        }
    }
    class Shape : Rectanguler 
    {
       

    }
    class main
    {
        static void Main(String[] args)
        {       
              Shape shape = new Shape();
            
            shape.GetArea(10,56);
            double area = shape.Area();
            double perimeter=shape.Perimeter();
            Console.WriteLine("Area of Rectangular are ");
            Console.WriteLine(area);
            Console.WriteLine("Perimeter of Rectangular are ");
            Console.WriteLine(perimeter);
            Console.ReadLine();
          

        }
    }

}