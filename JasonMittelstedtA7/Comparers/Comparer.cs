using JasonMittelstedtA7.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonMittelstedtA7.Comparers
{
    public class CarMakePriceComparer : IComparer<Car>
    {
        public int Compare(Car? x, Car? y)
        {
            if (x == null || y == null) return 0;

            int makeCompare = string.Compare(x.Make, y.Make, StringComparison.OrdinalIgnoreCase);
            if (makeCompare != 0)
                return makeCompare;

            // Sort by price ascending (change to descending if preferred)
            return x.Price.CompareTo(y.Price);
        }
    }
}
