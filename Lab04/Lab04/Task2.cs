using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Car
    {
        public string Name { get; set; }
        public int ProductionYear { get; set; }
        public int MaxSpeed { get; set; }
        public Car(string name, int productionYear, int maxSpeed)
        {
            Name = name;
            ProductionYear = productionYear;
            MaxSpeed = maxSpeed;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Production Year: {ProductionYear}, Max Speed: {MaxSpeed}";
        }
    }
    class CarComparer : IComparer<Car>
    {
        public enum SortBy
        {
            Name,
            ProductionYear,
            MaxSpeed
        }
        private SortBy sortBy;

        public CarComparer(SortBy sortBy)
        {
            this.sortBy = sortBy;
        }
        public int Compare(Car x, Car y)
        {
            switch (sortBy)
            {
                case SortBy.Name:
                    return string.Compare(x.Name, y.Name);
                case SortBy.ProductionYear:
                    return x.ProductionYear.CompareTo(y.ProductionYear);
                case SortBy.MaxSpeed:
                    return x.MaxSpeed.CompareTo(y.MaxSpeed);
                default:
                    throw new ArgumentException("Invalid sort by value");
            }
        }
    }
}
