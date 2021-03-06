using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Fitnesses;
using System.Collections.Generic;
using System.Linq;

namespace GeneticProfiles
{
    public class Fitness : IFitness
    {
        public double Evaluate(IChromosome chromosome)
        {
            List<GeneValue> genes = chromosome.GetGenes().Select(gene => gene.Value as GeneValue).ToList();

            var result = genes
                .GroupBy(gene => gene.Profile)
                .Select(gene => new
                {
                    Profile = gene.Key,
                    Total = gene.Sum(x => x.Span.Length)
                })
                .Select(r => new
                {
                    Profile = r.Profile,
                    Total = r.Total.MultiploSuperior(6)
                })
                .ToList();

            bool wrongProfile = false;
            genes.ForEach(gene =>
            {
                if (!gene.Span.PossibleProfiles.Contains(gene.Profile))
                    wrongProfile = true;
            });

            if (wrongProfile)
                return (1 / result.Sum(r => r.Profile.Weight * r.Total)) * 0.01;

            return 1 / result.Sum(r => r.Profile.Weight * r.Total);
        }
    }
}
