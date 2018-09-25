using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public abstract class Shape
    {
        private string myId;
        public Shape(string s)
        {
            Id = s;
        }
        public string Id
        {
            get
            {
                return myId;
            }
            set
            {
                myId = value;
            }
        }
        public abstract double Area
        {
            get;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Draw Shape Icon");
        }
    }
    //三角形
    public class Triangle:Shape
    {
        private int mySide1;
        private int mySide2;
        private int mySide3;
        public Triangle(int side1, int side2, int side3, string id) : base(id)
        {
            mySide1 = side1;
            mySide2 = side2;
            mySide3 = side3;
        }
        public override double Area
        {
            get
            {
                double P = (mySide1 + mySide2 + mySide3) / 2;
                return Math.Sqrt(P * (P - mySide1) * (P - mySide2) * (P - mySide3));
            }
        }
        public override void Draw()
        {
            Console.WriteLine("Draw Triangle");
        }
    }
    //圆形
    public class Circle : Shape
    {
        private int myRadius;
        public Circle(int radius, string id) : base(id)
        {
            myRadius = radius;
        }
        public override double Area
        {
            get
            {
                return myRadius * myRadius * System.Math.PI;
            }
        }
        public override void Draw()
        {
            Console.WriteLine("Draw Circle:" + myRadius);
        }
    }
    //正方形
    public class Square : Shape
    {
        private int mySide;
        public Square(int side,string id):base(id)
        {
            mySide = side;
        }
        public override double Area
        {
            get
            {
                return mySide * mySide;
            }
        }
        public override void Draw()
        {
            Console.WriteLine("Draw 4 Side:" + mySide);
        }
    }
    //长方形
    public class Rectangle:Shape
    {
        private int myWidth;
        private int myHeight;
        public Rectangle(int width,int height,string id):base(id)
        {
            myWidth = width;
            myHeight = height;
        }
        public override double Area
        {
            get
            {
                return myWidth * myHeight;
            }
        }
        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
    //测试
    public class TestClass
    {
        public static void Main()
        {
            Shape[] shapes =
            {
                new Triangle(3,4,5,"Triangle#1"),
                new Circle(3, "Circle#1"),
                new Square(5, "Square#1"),
                new Rectangle(4, 5, "Rectangle#1")
            };
            System.Console.WriteLine("Shapes Collection");
            foreach(Shape s in shapes)
            {
                System.Console.WriteLine(s.Id + "'s Area is " + s.Area);
            }
        }
    }
}
