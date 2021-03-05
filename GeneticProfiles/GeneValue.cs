using GeneticSharp.Domain.Randomizations;

namespace GeneticProfiles
{
    public class GeneValue
    {
        public Span Span { get; private set; }
        public Profile Profile { get; private set; }

        public GeneValue(Span span)
        {
            Span = span;
            Profile = Span.PossibleProfiles[RandomizationProvider.Current.GetInt(0, Span.PossibleProfiles.Count)];
        }

        public GeneValue(Span span, Profile profile)
        {
            Span = span;
            Profile = profile;
        }

        public override string ToString()
        {
            return $"{Span.Lenght}m -> {Profile.Name}";
        }
    }
}
