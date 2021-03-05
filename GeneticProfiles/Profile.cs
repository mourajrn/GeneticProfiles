using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticProfiles
{
    public class Profile
    {
        public string Name { get; private set; }
        public double Weight { get; private set; }

        public Profile(string name, double weight)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Weight = weight;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Name.Equals((obj as Profile).Name);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 19;

                hash = hash * 31 + Name.GetHashCode();

                return hash;
            }
        }
    }
}
