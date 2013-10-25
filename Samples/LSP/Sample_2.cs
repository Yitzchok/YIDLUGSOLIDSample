using System;

namespace Samples.LSP.Sample
{
    public class Sample2
    {
        public Sample2()
        {
            Test(new Rectangle(10, 20));
            Test(new Square(10));//this will throw an exception
        }

        public void Test(IShape shape)
        {
            Console.WriteLine(shape.Points());
        }
    }

    public interface IShape
    {
        string Points();
    }

    public class Rectangle : IShape
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public string Points()
        {
            return Width.ToString() + Height.ToString();
        }
    }

    public class Square : IShape
    {
        private int width;
        private int height;

        public Square(int i)
        {
            Height = i;
        }

        public int Width
        {
            get { return width; }
            set
            {
                width = value;
                height = value;
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                height = value;
                width = value;
            }
        }

        public string Points()
        {
            return width.ToString() + height.ToString();
        }
    }
}