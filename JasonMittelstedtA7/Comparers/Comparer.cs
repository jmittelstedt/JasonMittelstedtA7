using JasonMittelstedtA7.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonMittelstedtA7.Comparers
{
    /// <summary>
    /// Provides a comparison method for <see cref="Car"/> objects
    /// that sorts first by Make (alphabetically) and then by Price (ascending).
    /// </summary>
    public class CarMakePriceComparer : IComparer<Car>
    {
        /// <summary>
        /// Compares two <see cref="Car"/> objects by their Make and Price.
        /// </summary>
        /// <param name="x">The first Car object to compare.</param>
        /// <param name="y">The second Car object to compare.</param>
        /// <returns>
        /// A signed integer that indicates the relative values of the cars:
        /// <list type="bullet">
        /// <item><description>Less than zero – <paramref name="x"/> is less than <paramref name="y"/>.</description></item>
        /// <item><description>Zero – <paramref name="x"/> and <paramref name="y"/> are equal or one is null.</description></item>
        /// <item><description>Greater than zero – <paramref name="x"/> is greater than <paramref name="y"/>.</description></item>
        /// </list>
        /// </returns>
        public int Compare(Car? x, Car? y)
        {
            if (x == null || y == null) return 0;

            int makeCompare = string.Compare(x.make, y.make, StringComparison.OrdinalIgnoreCase);
            if (makeCompare != 0)
                return makeCompare;

            // Sort by price ascending (change to descending if preferred)
            return x.price.CompareTo(y.price);
        }
    }
}
