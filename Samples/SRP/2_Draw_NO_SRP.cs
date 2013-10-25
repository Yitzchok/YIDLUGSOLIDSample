using System;

namespace Samples.SRP
{
    public abstract class Shape
    {
        public abstract void Draw();
        public abstract string Area { get; }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine(Area);
        }

        public override string Area
        {
            get { return "Rectangle"; }
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine(Area);
        }

        public override string Area
        {
            get { return "Square"; }
        }
    }
}