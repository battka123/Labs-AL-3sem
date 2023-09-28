using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class CarCatalor : IEnumerable<Car>
    {
        private List<Car> cars = new List<Car>();

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public IEnumerator<Car> GetEnumerator()
        {
            return cars.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<Car> GetReverseIterator()
        {
            for (int i = cars.Count - 1; i >= 0; i--)
            {
                yield return cars[i];
            }
        }

        public IEnumerable<Car> GetCarsByYear(int year)
        {
            foreach (Car car in cars)
            {
                if (car.ProductionYear == year)
                {
                    yield return car;
                }
            }
        }

        public IEnumerable<Car> GetCarsByMaxSpeed(int maxSpeed)
        {
            foreach (Car car in cars)
            {
                if (car.MaxSpeed <= maxSpeed)
                {
                    yield return car;
                }
            }
        }
    }
}
