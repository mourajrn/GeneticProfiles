using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticProfiles
{
    public class Span
    {
        public double Lenght { get; private set; }
        public List<Profile> PossibleProfiles { get; private set; }

        public Span(double lenght, List<Profile> possibleProfiles)
        {
            Lenght = lenght;
            PossibleProfiles = possibleProfiles ?? throw new ArgumentNullException(nameof(possibleProfiles));
        }

        public override string ToString()
        {
            return Lenght.ToString();
        }
    }
}
