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
        public IChromosome Solve()
        {
            var selection = new RouletteWheelSelection();
            var crossover = new TwoPointCrossover();
            var mutation = new UniformMutation();
            var fitness = new Fitness();
            var chromosome = new Chromosome(Main.Spans);
            var population = new Population(1000, 1000, chromosome);

            var ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new GenerationNumberTermination(100);

            ga.CrossoverProbability = 1;
            ga.MutationProbability = 0.5F;

            ga.Start();

            return ga.BestChromosome;
        }
    }
}
