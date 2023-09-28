using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    // Реалзуется из интерфейса
    class Car : IEquatable<Car>
    {
        public string Name { get; set; }
        public string Engine { get; set; }
        public int MaxSpeed { get; set; }
        // Переопределил оператор
        public override string ToString()
        {
            return Name;
        }
        // Сравнение машин
        public bool Equals(Car other)
        {
            if (other == null) return false;
            return (Name == other.Name) && (Engine == other.Engine) && (MaxSpeed == other.MaxSpeed);
        }
    }

    class CarsCatalog
    {
        private List<Car> cars;
        // Конструктор для создания каталога
        public CarsCatalog()
        {
            cars = new List<Car>();
        }
        // Индексатор
        public Car this[int index]
        {
            get { return cars[index]; }
            set { cars[index] = value; }
        }
        public void Info(int index)
        {
            Console.WriteLine(cars[index].Name);
            Console.WriteLine(cars[index].Engine);
        }
        // Добавление в список машины
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        // Удаление из списка машины
        public void RemoveCar(Car car)
        {
            cars.Remove(car);
        }
    }
}
