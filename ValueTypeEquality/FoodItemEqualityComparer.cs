using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeEquality
{
    class FoodItemEqualityComparer : EqualityComparer<FoodItem>
    {
        private static readonly FoodItemEqualityComparer _instance = new FoodItemEqualityComparer();

        public static FoodItemEqualityComparer Instance { get { return _instance; } }

        public FoodItemEqualityComparer() { }
        
        public override bool Equals(FoodItem x, FoodItem y)
        {
            //return x.Name.ToUpperInvariant() == y.Name.ToUpperInvariant() && x.Group == y.Group;
            return StringComparer.OrdinalIgnoreCase.Equals(x.Name, y.Name) && x.Group == y.Group; //Can use System.StringComparer for strings
        }

        public override int GetHashCode(FoodItem obj)
        {
            //return obj.Name.ToUpperInvariant().GetHashCode() ^ obj.Group.GetHashCode();
            return StringComparer.OrdinalIgnoreCase.GetHashCode(obj.Name) ^ obj.Group.GetHashCode(); //Can use System.StringComparer for strings
        }
    }
}
