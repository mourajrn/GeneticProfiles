using GeneticSharp.Domain.Chromosomes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticProfiles
{
    public class Chromosome : ChromosomeBase
    {
        public List<Span> Spans { get; private set; }

        public Chromosome(List<Span> spans) : base(spans.Count)
        {
            Spans = spans;
            CreateGenes();
        }

        public override IChromosome CreateNew()
        {
            return new Chromosome(Spans);
        }

        public override GeneticSharp.Domain.Chromosomes.Gene GenerateGene(int geneIndex)
        {
            return new Gene(new GeneValue(Spans[geneIndex]));
        }
    }
}
