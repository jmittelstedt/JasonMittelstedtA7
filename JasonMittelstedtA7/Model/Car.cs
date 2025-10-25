using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonMittelstedtA7.Model
{
    public class Car : IComparable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }

        public int CompareTo(Car? other)
        {
            if (other == null) return 1;
            return string.Compare(Make, other.Make, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Price: {Price:C}, Mileage: {Mileage}, Color: {Color}";
        }
    }
}
