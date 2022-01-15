using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEquationSolver
{
    public class Selection
    {
        private static Random _rand = new Random();

        public static Chromosome GetBest(List<Chromosome> population)
        {
            return new Chromosome(population.OrderByDescending(chromosome => chromosome.Fitness).First());
        }
    }

    /// <summary>
    /// Clasa care implementeaza algoritmul diferential pentru optimizare
    /// </summary>
    public class DifferentialEvolutionaryAlgorithm
    {
        private static Random _rand = new Random();

        /// <summary>
        /// Metoda de optimizare care gaseste solutia problemei
        /// </summary>
        public Chromosome Solve(IOptimizationProblem p, int populationSize, int maxGenerations, double crossoverRate, double motivationRate)
        {
            Chromosome bestSolution = null;
            List<Chromosome> populationList = new List<Chromosome>();

            // 1. initializare
            for (int i = 0; i < populationSize; i++)
            {
                populationList.Add(p.MakeChromosome());
                p.ComputeFitness(populationList[i]);
            }

            for (int gen = 0; gen < maxGenerations; gen++)
            {
/*                Chromosome[] newPopulation = new Chromosome[populationSize];*/
                List<Chromosome> newPopulationList = new List<Chromosome>();

                // 2. mutatie
                foreach(Chromosome chromosome in populationList)
                {
                    int a, b, c;

                    do
                    {
                        a = _rand.Next(0, populationList.Count - 1);
                        b = _rand.Next(0, populationList.Count - 1);
                        c = _rand.Next(0, populationList.Count - 1);
                    } while (a == b || b == c || a == c);

                    Chromosome chromosome1 = populationList[a];
                    Chromosome chromosome2 = populationList[b];
                    Chromosome chromosome3 = populationList[c];

                    Chromosome newChild = new Chromosome(chromosome1);
                    int divisionPoint = _rand.Next(0, populationList.Count - 1);
                    for (int i = 0; i < newChild.Genes.Length; i++)
                    {
                        // 3. incrucisare
                        if (_rand.NextDouble() < crossoverRate || i == divisionPoint)
                        {
                            newChild.Genes[i] = chromosome1.Genes[i] + motivationRate * (chromosome2.Genes[i] - chromosome3.Genes[i]);
                        } else
                        {
                            newChild.Genes[i] = chromosome.Genes[i];
                        }
                    }

                    // 4. selectie
                    p.ComputeFitness(newChild);
                    if (newChild.Fitness >= chromosome.Fitness) 
                    {
                        newPopulationList.Add(newChild);
                    } else
                    {
                        newPopulationList.Add(chromosome);
                    }
                }

                populationList.Clear();
                populationList = newPopulationList;

                bestSolution = Selection.GetBest(populationList);
            }

            return bestSolution;
        }
    }
}
