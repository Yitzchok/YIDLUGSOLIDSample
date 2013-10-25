using System;

namespace Samples.SRP
{
    public interface Draw
    {
        string Area { get; }
    }

    public class SquareShapeGeometry : Draw
    {
        public string Area { get { return "Square"; } }
    }

    public class RectangleShapeGeometry : Draw
    {
        public string Area { get { return "Rectangle"; } }
    }


    public class DrawOnConsole
    {
        public void Draw(Draw shape)
        {
            Console.WriteLine(shape.Area);
        }
    }
}