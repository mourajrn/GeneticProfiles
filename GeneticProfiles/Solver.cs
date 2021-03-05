using GeneticSharp.Domain;
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
        public void Solve()
        {
            List<Span> spans = new List<Span>();

            spans.Add(new Span(4, new List<Profile>
            {
                new Profile("22", 22),
                new Profile("25", 25),
            }));
            spans.Add(new Span(5, new List<Profile>
            {
                new Profile("25", 25),
            }));
            spans.Add(new Span(3, new List<Profile>
            {
                new Profile("22", 22),
                new Profile("25", 25),
            }));
            spans.Add(new Span(3, new List<Profile>
            {
                new Profile("22", 22),
                new Profile("25", 25),
            }));
            spans.Add(new Span(2, new List<Profile>
            {
                new Profile("18", 18),
                new Profile("22", 22),
                new Profile("25", 25),
            }));

            var selection = new RouletteWheelSelection();
            var crossover = new TwoPointCrossover();
            var mutation = new UniformMutation();
            var fitness = new Fitness();
            var chromosome = new Chromosome(spans);
            var population = new Population(1000, 1000, chromosome);

            var ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new GenerationNumberTermination(100);

            ga.CrossoverProbability = 1;
            ga.MutationProbability = 0.5F;

            ga.Start();
        }
    }
}
