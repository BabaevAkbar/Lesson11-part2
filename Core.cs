using System;

namespace Core
{
    interface IMovable
    {
        void Move(double speed) { }
    }

    abstract class Appliance
    {
        public abstract void TurnOn();
        public abstract void TurnOff();
    }


    class Car : IMovable
    {
        private double Speed{ get; set; }

        public void Move(double speed)
        {
            Speed = speed;
            Console.WriteLine($"Машина едет со скоростью {Speed}");
        }
    }

    class Robot : IMovable
    {
        private double Speed{ get; set; }

        public void Move(double speed)
        {
            Speed = speed;
            Console.WriteLine($"Робот идет со скоростью {Speed}");
        }
    }

    class WashingMachine : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Стиральная машина влючена.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Стиральная машина выключена.");
        }
    }

    class Refrigerator : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Холодильник включен.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Холодильник выключен.");
        }
    }

}