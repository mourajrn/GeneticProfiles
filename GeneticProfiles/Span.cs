using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticProfiles
{
    public class Span
    {
        public double Length { get; private set; }
        public List<Profile> PossibleProfiles { get; private set; }

        public Span(double length, List<Profile> possibleProfiles)
        {
            Length = length;
            PossibleProfiles = possibleProfiles ?? throw new ArgumentNullException(nameof(possibleProfiles));
        }

        public override string ToString()
        {
            return Length.ToString();
        }
    }
}
