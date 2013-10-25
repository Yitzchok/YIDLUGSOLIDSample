using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container
                .Register(
                Component.For<IDoor>().ImplementedBy<SlidingDoor>().Named(""),
                Component.For<House>().ImplementedBy<House>()
                );


            var house = container.Resolve<House>();

            house.CloseAllDoors();

            Console.Read();
        }
    }

    public class House
    {
        private readonly IDoor door;

        public House(IDoor door)
        {
            this.door = door;
        }

        public void CloseAllDoors()
        {
            door.Close();

        }
    }
}
