using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonMittelstedtA7.Model
{
    public class Car : IComparable<Car>
    {
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public decimal price { get; set; }
        public int cylinders { get; set; }
        public int mileage { get; set; }
        public string color { get; set; }

        public int CompareTo(Car? other)
        {
            if (other == null) return 1;
            return string.Compare(make, other.make, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"Make: {make}, Model: {model}, Price: {price:C}, Mileage: {mileage}, Color: {color}";
        }
    }
}
