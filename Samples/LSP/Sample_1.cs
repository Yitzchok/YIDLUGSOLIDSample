using System;
using Samples.SRP;

namespace Samples.LSP
{
    public class Draw
    {
        public void DrawShape(Shape shape)
        {
            if (shape is Rectangle)
                DrawRectangle(shape as Rectangle);
            else if (shape is Square)
                DrawSquare(shape as Square);
        }

        void DrawRectangle(Rectangle rectangle)
        {
            Console.WriteLine(rectangle.Area);
        }

        void DrawSquare(Square square)
        {
            Console.WriteLine(square.Area);
        }
    }
}