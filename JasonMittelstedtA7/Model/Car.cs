using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonMittelstedtA7.Model
{
    /// <summary>
    /// Represents a car with basic details such as make, model, year, price, engine, and color.
    /// </summary>
    public class Car : IComparable<Car>
    {
        /// <summary>
        /// Gets or sets the make (manufacturer) of the car.
        /// </summary>
        public string make { get; set; }

        /// <summary>
        /// Gets or sets the model of the car.
        /// </summary>
        public string model { get; set; }

        /// <summary>
        /// Gets or sets the year the car was manufactured.
        /// </summary>
        public int year { get; set; }

        /// <summary>
        /// Gets or sets the price of the car.
        /// </summary>
        public decimal price { get; set; }

        /// <summary>
        /// Gets or sets the number of cylinders in the car's engine.
        /// </summary>
        public int cylinders { get; set; }

        /// <summary>
        /// Gets or sets the mileage (in miles) of the car.
        /// </summary>
        public int mileage { get; set; }

        /// <summary>
        /// Gets or sets the color of the car.
        /// </summary>
        public string color { get; set; }

        /// <summary>
        /// Compares the current <see cref="Car"/> to another <see cref="Car"/> based on the make.
        /// </summary>
        /// <param name="other">The other <see cref="Car"/> to compare with the current car.</param>
        /// <returns>
        /// A signed integer that indicates the relative order of the cars:
        /// <list type="bullet">
        /// <item><description>Less than zero – This car precedes <paramref name="other"/> in the sort order.</description></item>
        /// <item><description>Zero – This car occurs in the same position as <paramref name="other"/>.</description></item>
        /// <item><description>Greater than zero – This car follows <paramref name="other"/> in the sort order.</description></item>
        /// </list>
        /// </returns>
        public int CompareTo(Car? other)
        {
            if (other == null) return 1;
            return string.Compare(make, other.make, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Returns a string representation of the car, including make, model, price, mileage, and color.
        /// </summary>
        /// <returns>A formatted string containing car details.</returns>
        public override string ToString()
        {
            return $"Make: {make}, Model: {model}, Price: {price:C}, Mileage: {mileage}, Color: {color}";
        }
    }
}
