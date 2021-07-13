using System;
using System.Collections.Generic;
using GitExercise_1;
using NUnit.Framework;


namespace GitExercise_1_Tests
{
    [TestFixture]
    public class PointTests
    {

        [Test]
        public void Creating_Point_instance_with_empty_constructor()
        {
            // Arrange
            Point P1;

            // Act
            P1 = new Point();

            // Assert
            Assert.IsInstanceOf<Point>(P1);
            Assert.IsNotNull(P1);

        }


        [Test]
        public void Creating_Point_instance_with_constructor()
        {
            // Arrange
            Point P1;

            // Act
            P1 = new Point(12.156, 0.125);

            // Assert
            Assert.IsInstanceOf<Point>(P1);
            Assert.IsNotNull(P1);
            
            Assert.AreEqual(12.156, P1.x);
            Assert.AreEqual(0.125, P1.y);
        }


        [Test]
        public void Number_Of_Points()
        {
            // Arrange
            Point.number = 0;
            List<Point> listOfPoints = new List<Point> { new Point(), new Point(), new Point(), new Point() };

            // Act
            var result = Point.number;

            // Assert
            Assert.AreEqual(4, result);
        }
    }






    [TestFixture]
    public class LineTests
    {
        [Test]
        public void Creating_Line_instance_with_constructor()
        {
            // Arrange
            Point P1 = new Point{x = 0, y = 12};
            Point P2 = new Point {x = 12, y = 0};


            // Act
            Line L1 = new Line(P1, P2);


            // Assert
            Assert.IsInstanceOf<Line>(L1);

            Assert.IsNotNull(L1);

            Assert.AreEqual(0, L1.p1.x);
            Assert.AreEqual(12, L1.p1.y);

            Assert.AreEqual(12, L1.p2.x);
            Assert.AreEqual(0, L1.p2.y);
        }


        [Test]
        public void Line_Length_test()
        {
            // Arrange
            Point P1 = new Point { x = 0, y = 12 };
            Point P2 = new Point { x = 12, y = 0 };
            Line L1 = new Line(P1, P2);


            // Act
            var result = L1.Length();


            // Assert
            Assert.AreEqual(Math.Sqrt(288), result);
            Assert.AreNotEqual(Math.Sqrt(288.1), result);
            Assert.AreNotEqual(Math.Sqrt(287.9), result);
        }


        [Test]
        public void Line_static_Length_test()
        {
            // Arrange
            Point P1 = new Point { x = 0, y = 12 };
            Point P2 = new Point { x = 12, y = 0 };

            // Act
            var result = Line.Length(P1, P2);

            // Assert

            Assert.AreEqual(Math.Sqrt(288), result);
            Assert.AreNotEqual(Math.Sqrt(288.1), result);
            Assert.AreNotEqual(Math.Sqrt(287.9), result);
        }
    }







    [TestFixture]
    public class TriangleTests
    {

        [Test]
        public void Creating_Triangle_instance_with_empty_constructor()
        {
            // Arrange
            Triangle T1;

            // Act
            T1 = new Triangle();

            // Assert
            Assert.IsInstanceOf<Triangle>(T1);
            Assert.IsNotNull(T1);
        }


        [Test]
        public void Creating_Triangle_instance_with_constructor()
        {
            // Arrange
            Point P1 = new Point { x = 0, y = 12 };
            Point P2 = new Point { x = 12, y = 0 };
            Point P3 = new Point { x = 0, y = 0 };

            Triangle T1;

            // Act
            T1 = new Triangle(P1, P2, P3);

            // Assert
            Assert.IsInstanceOf<Triangle>(T1);
            Assert.IsNotNull(T1);

            Assert.AreEqual(0, T1.p1.x);
            Assert.AreEqual(12, T1.p1.y);

            Assert.AreEqual(12, T1.p2.x);
            Assert.AreEqual(0, T1.p2.y);

            Assert.AreEqual(0, T1.p3.x);
            Assert.AreEqual(0, T1.p3.y);
        }



        [Test]
        public void Is_Triangle_instance_of_ISHape()
        {
            // Arrange
            Triangle T1;

            // Act
            T1 = new Triangle();

            // Assert
            Assert.IsNotNull(T1);
            Assert.IsInstanceOf<IShape>(T1);
        }


        [Test]
        public void Triangle_Area_Test()
        {
            // Arrange
            Point P1 = new Point { x = 0, y = 12 };
            Point P2 = new Point { x = 12, y = 0 };
            Point P3 = new Point { x = 0, y = 0 };

            Triangle T1 = new Triangle(P1, P2, P3); ;
            double delta = 0.001; // deviation from expected value

            // Act
            var result = T1.Area();

            // Assert
            Assert.AreEqual(0.5*12*12 , result, delta);
        }
        

        [Test]
        public void Number_Of_Triangles()
        {
            // Arrange
            Triangle.number = 0;
            List<Triangle> listOfTriangles = new List<Triangle> { new Triangle(), new Triangle(), new Triangle(), new Triangle() };

            // Act
            var result = Triangle.number;

            // Assert
            Assert.AreEqual(4, result);
        }
    }







    [TestFixture]
    public class RectangleTests
    {

        [Test]
        public void Creating_Rectangle_instance_with_empty_constructor()
        {
            // Arrange
            Rectangle R1;

            // Act
            R1 = new Rectangle();

            // Assert
            Assert.IsInstanceOf<Rectangle>(R1);
            Assert.IsNotNull(R1);
        }



        [Test]
        public void Creating_Rectangle_instance_with_constructor()
        {
            // Arrange
            Point P1 = new Point { x = 0, y = 0 };
            Point P2 = new Point { x = 12, y = 0 };
            Point P3 = new Point { x = 12, y = 6 };
            Point P4 = new Point { x = 0, y = 6 };

            Rectangle R1;

            // Act
            R1 = new Rectangle(P1, P2, P3, P4);

            // Assert
            Assert.IsInstanceOf<Rectangle>(R1);
            Assert.IsNotNull(R1);

            Assert.AreEqual(0, R1.p1.x);
            Assert.AreEqual(0, R1.p1.y);

            Assert.AreEqual(12, R1.p2.x);
            Assert.AreEqual(0, R1.p2.y);

            Assert.AreEqual(12, R1.p3.x);
            Assert.AreEqual(6, R1.p3.y);

            Assert.AreEqual(0, R1.p4.x);
            Assert.AreEqual(6, R1.p4.y);
        }



        [Test]
        public void Is_Rectangle_instance_of_ISHape()
        {
            // Arrange
            Rectangle R1;

            // Act
            R1 = new Rectangle();

            // Assert
            Assert.IsNotNull(R1);
            Assert.IsInstanceOf<IShape>(R1);
        }
        

        [Test]
        public void Rectangle_Area_Test()
        {
            // Arrange
            Point P1 = new Point { x = 0, y = 0 };
            Point P2 = new Point { x = 12, y = 0 };
            Point P3 = new Point { x = 12, y = 6 };
            Point P4 = new Point { x = 0, y = 6 };

            Rectangle R1 = new Rectangle(P1, P2, P3, P4);
            double delta = 0.001; // deviation from expected value

            // Act
            var result = R1.Area();

            // Assert
            Assert.AreEqual(6.0 * 12.0, result, delta);
        }


        [Test]
        public void Number_Of_Rectangles()
        {
            // Arrange
            Rectangle.number = 0;
            List<Rectangle> listOfRectangles = new List<Rectangle>{new Rectangle(), new Rectangle(), new Rectangle(), new Rectangle()};

            // Act
            var result = Rectangle.number;

            // Assert
            Assert.AreEqual(4, result);
        }
    }




    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void Creating_Circle_instance_with_empty_constructor()
        {
            // Arrange
            Circle C1;

            // Act
            C1 = new Circle();

            // Assert
            Assert.IsInstanceOf<Circle>(C1);
            Assert.IsNotNull(C1);
        }



        [Test]
        public void Creating_Circle_instance_with_constructor()
        {
            // Arrange
            Point centrePoint = new Point { x = 0, y = 0 };
            double rad = 12.56;

            Circle C1;

            // Act
            C1 = new Circle(centrePoint, rad);

            // Assert
            Assert.IsInstanceOf<Circle>(C1);
            Assert.IsNotNull(C1);

            Assert.AreEqual(0, C1.centrPoint.x);
            Assert.AreEqual(0, C1.centrPoint.y);

            Assert.AreEqual(12.56, C1.radius);
        }




        [Test]
        public void Is_Circle_instance_of_ISHape()
        {
            // Arrange
            Circle C1;

            // Act
            C1 = new Circle();

            // Assert
            Assert.IsNotNull(C1);
            Assert.IsInstanceOf<IShape>(C1);
        }


        [Test]
        public void Circle_Area_Test()
        {
            // Arrange
            Point centrePoint = new Point { x = 0, y = 0 };
            double rad = 12.56;

            Circle C1 = new Circle(centrePoint, rad);

            double delta = 0.001; // deviation from expected value

            // Act
            var result = C1.Area();

            // Assert
            Assert.AreEqual( Math.PI*12.56*12.56, result, delta);
        }




        [Test]
        public void Number_Of_Circle()
        {
            // Arrange
            Circle.number = 0;
            List<Circle> listOfTriangles = new List<Circle> { new Circle(), new Circle(), new Circle(), new Circle() };

            // Act
            var result = Circle.number;

            // Assert
            Assert.AreEqual(4, result);
        }
    }
}