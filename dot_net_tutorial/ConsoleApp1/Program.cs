using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        private int maxSpeed;
        private int speed = 0;
        private string model;

        public Car(int maxSpeed, string model)
        {
            this.maxSpeed = maxSpeed;
            this.model = model;
        }

        public void ShowCarInformation()
        {
            Console.WriteLine(model + "의 현재 속도: " + speed + "km/h, 최대 속도: " + maxSpeed + "km/h");

        }
        public void speedUp(int increment)
        {
            if (speed + increment > maxSpeed)
                Console.WriteLine("최대 속도 " + maxSpeed + "km/h를 넘길 수 없습니다.");
            else
            {
                speed += increment;
                Console.WriteLine(model + "의 현재 속도는 " + speed + "km/h 입니다.");
            }
        }

        public void speedDown(int decrement)
        {
            if (speed - decrement < 0)
                Console.WriteLine("속도는 0 아래로 떨어질 수 없습니다.");
            else
            {
                speed -= decrement;
                Console.WriteLine(model + "의 현재 속도는 " + speed + "km/h 입니다.");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(325, "Audi");

            car.ShowCarInformation();
            car.speedUp(50);
            car.speedUp(40);
            car.speedUp(210);
            car.speedUp(30);
        }
    }
}
