using System;

namespace ConsoleApplication1
{
    public interface IDoor
    {
        void Open();
        void Close();
    }

    public class Door : IDoor
    {
        private bool closed = true;
        public void Open()
        {
            closed = false;

            Console.WriteLine("Door opened");
        }

        public void Close()
        {
            closed = true;
            Console.WriteLine("Door closed");
        }
    }

    public class SlidingDoor : IDoor
    {
        private bool closed = true;
        public void Open()
        {
            closed = false;

            Console.WriteLine("Door sliding open");
        }

        public void Close()
        {
            closed = true;
            Console.WriteLine("Door sliding close");
        }
    }
}