using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticProfiles
{
    public class Span
    {
        public string Title { get; private set; }
        public double Length { get; private set; }
        public List<Profile> PossibleProfiles { get; private set; }

        public Span(string title, double length, List<Profile> possibleProfiles)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Length = length;
            PossibleProfiles = possibleProfiles ?? throw new ArgumentNullException(nameof(possibleProfiles));
        }

        public override string ToString()
        {
            return Length.ToString();
        }
    }
}
