using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Vehicle
    {
        protected uint cost;
        protected uint speed;
        protected string date;

        public Vehicle(uint cost, uint speed, string date)
        {
            this.cost = cost;
            this.speed = speed;
            this.date = date;
        }
        public virtual void Info()
        {

        }
    }

    public class Plane : Vehicle
    {
        uint height;
        uint num;
        public Plane(uint cost, uint speed, string date, uint height, uint num) : base(cost, speed, date)
        {
            this.height = height;
            this.num = num;
        }
        public override void Info()
        {
            Console.WriteLine("Самолёт");
            Console.WriteLine($"Стоимость: {this.cost}");
            Console.WriteLine($"Скорость: {this.speed}");
            Console.WriteLine($"Дата: {this.date}");
            Console.WriteLine($"Высота: {height}");
            Console.WriteLine($"Число пассажиров: {num}");
            Console.WriteLine("\n");
        }
    }
    public class Car : Vehicle
    {
        public Car(uint cost, uint speed, string date) : base(cost, speed, date)
        {
        }
        public override void Info()
        {
            Console.WriteLine("Машина");
            Console.WriteLine($"Стоимость: {this.cost}");
            Console.WriteLine($"Скорость: {this.speed}");
            Console.WriteLine($"Дата: {this.date}");
            Console.WriteLine("\n");
        }
    }
    public class Ship : Vehicle
    {
        uint num;
        string port;

        public Ship(uint cost, uint speed, string date, uint num, string port) : base(cost, speed, date)
        {

            this.port = port;
            this.num = num;
        }
        public override void Info()
        {
            Console.WriteLine("Корабль");
            Console.WriteLine($"Стоимость: {this.cost}");
            Console.WriteLine($"Скорость: {this.speed}");
            Console.WriteLine($"Дата: {this.date}");
            Console.WriteLine($"Порт приписки: {port}");
            Console.WriteLine($"Число пассажиров: {num}");
            Console.WriteLine("\n");
        }
    }
}
