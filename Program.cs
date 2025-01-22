using System;
using Core;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
            car.Move(110);

            IMovable robot = new Robot();
            robot.Move(20);

        }
    }
}