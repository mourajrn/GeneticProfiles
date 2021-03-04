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
        public Chromosome(int length) : base(length)
        {
        }

        public override IChromosome CreateNew()
        {
            throw new NotImplementedException();
        }

        public override Gene GenerateGene(int geneIndex)
        {
            throw new NotImplementedException();
        }
    }
}
