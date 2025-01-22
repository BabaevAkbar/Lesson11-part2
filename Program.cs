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

            Appliance machine = new WashingMachine();
            machine.TurnOn();
            machine.TurnOff();

            Appliance refrigerator = new Refrigerator();
            refrigerator.TurnOn();
            refrigerator.TurnOff();
        }
    }
}