using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExercise_1
{
    public interface IShape 
    {
        double Area();
    
    }




    public class Point
    {
        public static int number = 0;
        public double x { set; get; }
        public double y { set; get; }
        public Point() 
        {
            number++;        
        }
    }



    public class Line
    {
        public Point p1 { set; get; }
        public Point p2 { set; get; }


        public Line() 
        {
        
        }

        public Line(Point p1, Point p2) 
        {
            this.p1 = p1;
            this.p2 = p2;      
        }

        public double Length()
        {
            return Math.Sqrt( Math.Pow((p2.x - p1.x), 2) + Math.Pow((p2.y - p1.y), 2) );        
        }
        public static double Length(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((p2.x - p1.x), 2) + Math.Pow((p2.y - p1.y), 2));
        }
    }


    public class Triangle : IShape
    {
        public static int number = 0;
        public Point p1 { set; get; }
        public Point p2 { set; get; }
        public Point p3 { set; get; }
        public Triangle() 
        {
            number++;
            p1 = new Point { x = 0, y = 0 };
            p2 = new Point { x = 2, y = 0 };
            p3 = new Point { x = 1, y = 2 };
        }

        public Triangle(Point p1, Point p2, Point p3)
        {
            number++;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public double Area()
        {
            double a = Line.Length(p1, p2);
            double b = Line.Length(p2, p3);
            double c = Line.Length(p3, p1);

            double p = (a + b + c) / 2.0;

            return Math.Sqrt(p*((p - a) * (p - b) * (p - c)));
        }
    }


    public class Rectangle : IShape    
    {
        public static int number = 0;
        public Point p1 { set; get; }
        public Point p2 { set; get; }
        public Point p3 { set; get; }
        public Point p4 { set; get; }

        public Rectangle() 
        {
            number++;
            p1 = new Point { x = 0, y = 0 };
            p2 = new Point { x = 2, y = 0 };
            p3 = new Point { x = 2, y = 2 };
            p4 = new Point { x = 0, y = 2 };
        }

        public Rectangle(Point p1, Point p2, Point p3, Point p4)
        {
            number++;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }

        public double Area()
        {
            return Line.Length(p1, p2) * Line.Length(p1, p4);
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point {x = 1, y = 3 };
            Console.WriteLine(Point.number);

            Point p2 = new Point { x = 1, y = 10 };
            Point p3 = new Point { x = 0, y = 5 };

            Line l1 = new Line(p2, p3);
            Console.WriteLine("Длина = " + l1.Length());
            Console.WriteLine("Длина = " + Line.Length(new Point { x=-10, y=12}, new Point { x=0.1, y=3.742}));

            Triangle T1 = new Triangle { p1 = new Point {x=0, y=0 }, p2 = new Point {x=3, y=0 }, p3 = new Point {x=3, y=4 } };
            Console.WriteLine("Площадь треугольника Т1 = " + T1.Area() );

            Rectangle R1 = new Rectangle { p1 = new Point { x = 0, y = 0 }, p2 = new Point { x = 3, y = 0 }, p3 = new Point { x = 3, y = 4 }, p4 = new Point { x = 0, y = 4 } };
            Console.WriteLine("Площадь прямоугольника R1 = " + R1.Area());

            Rectangle R2 = new Rectangle { p1 = new Point { x = -10, y = -10 }, p2 = new Point { x = 0, y = -10 }, p3 = new Point { x = 0, y = 0 }, p4 = new Point { x = -10, y = 0 } };
            Console.WriteLine("Площадь прямоугольника R2 = " + R2.Area());

            Console.ReadLine();
        }
    }
}
