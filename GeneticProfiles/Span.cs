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

        public void Modify(string title, double length, List<Profile> possibleProfiles)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Length = length;
            PossibleProfiles = possibleProfiles ?? throw new ArgumentNullException(nameof(possibleProfiles));
        }

        public void AddProfile(Profile profile)
        {
            if (!PossibleProfiles.Contains(profile))
                PossibleProfiles.Add(profile);
        }

        public void RemoveProfile(Profile profile)
        {
            if (PossibleProfiles.Contains(profile))
                PossibleProfiles.Remove(profile);
        }

        public override string ToString()
        {
            return Length.ToString();
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Span other = (Span)obj;
                return Title.Equals(other.Title);
            }
        }

        public override int GetHashCode()
        {
            int hashCode = 955492210;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + Length.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Profile>>.Default.GetHashCode(PossibleProfiles);
            return hashCode;
        }
    }
}
