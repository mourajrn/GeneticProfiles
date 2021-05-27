using GeneticSharp.Domain;
using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Crossovers;
using GeneticSharp.Domain.Mutations;
using GeneticSharp.Domain.Populations;
using GeneticSharp.Domain.Selections;
using GeneticSharp.Domain.Terminations;
using System.Collections.Generic;

namespace GeneticProfiles
{
    public class Solver
    {
        public IChromosome Solve(List<Span> spans)
        {
            var selection = new RouletteWheelSelection();
            var crossover = new TwoPointCrossover();
            var mutation = new UniformMutation();
            var fitness = new Fitness();
            var chromosome = new Chromosome(spans);
            var population = new Population(100, 100, chromosome);

            var ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new GenerationNumberTermination(100);

            ga.CrossoverProbability = 0.8F;
            ga.MutationProbability = 0.1F;

            ga.Start();

            return ga.BestChromosome;
        }
    }
}
