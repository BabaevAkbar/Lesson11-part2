using System;

namespace Core
{
    interface IMovable
    {
        void Move(double speed) { }
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
}