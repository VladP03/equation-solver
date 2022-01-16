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

        // O(n)
        public static Chromosome GetBest(List<Chromosome> population) 
        {
            Chromosome bestChromosome= population.First();

            foreach(var chromosome in population)
            {
                if (bestChromosome.Fitness < chromosome.Fitness)
                {
                    bestChromosome = chromosome;
                }
            }

            return bestChromosome;
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
        
        //Complexitatea algoritmului apartine clasei O(n^2)
        public Chromosome Solve(IOptimizationProblem p, int populationSize, int maxGenerations, double crossoverRate, double motivationRate)
        {
            Chromosome bestSolution = null; // A1
                                         
            List<Chromosome> populationList = new List<Chromosome>(); //A2

            // 1. initializare
            for (int i = 0; i < populationSize; i++) // O(populationSize)
            {
                // Pas 1: 0<populationSize      
                //      Se creaza un nou cromozom si se adauga in populatie         A3
                //      Se calculeaza fitness-ul cromozomului adaugat anterior      A4
                // Pas k: k<populationSize      A
                //      Se creaza un nou cromozom si se adauga in populatie         A[2+2*k+1]
                //      Se calculeaza fitness-ul cromozomului adaugat anterior      A[2+2*k+2]
                // Pas populationSize-1: populationSize-1<populationSize
                //      Se creaza un nou cromozom si se adauga in populatie         A[2+2*(populationSize-1)+1]
                //      Se calculeaza fitness-ul cromozomului adaugat anterior      A[2+2*(populationSize-1)+2]
                populationList.Add(p.MakeChromosome());     // Complexitatea este aproximata la O(1)
                p.ComputeFitness(populationList[i]);        // Complexitatea este aproximata la O(1)
            }
            // Nr instructiuni la momentul curent: A[2+2*(populationSize)] + A[2*(populationSize+1)](numar de instructiuni introduse de bucla for)

            for (int gen = 0; gen < maxGenerations; gen++) // O(maxGeneration)
            {
                List<Chromosome> newPopulationList = new List<Chromosome>(); // A1 de maxGenerations ori 

                // 2. mutatie
                foreach(Chromosome chromosome in populationList) // O(populationSize*maxGeneration)
                {
                    int a, b, c;

                    do // Presupunem O(1) intrucat valorile random obtinute nu pot fi prezise 
                    {
                        a = _rand.Next(0, populationList.Count);    // A2 de maxGenerations*populationSize ori
                        b = _rand.Next(0, populationList.Count);    // A3 de maxGenerations*populationSize ori
                        c = _rand.Next(0, populationList.Count);    // A4 de maxGenerations*populationSize ori
                    } while (a == b || b == c || a == c);           

                    Chromosome chromosome1 = populationList[a];     // A5 de maxGenerations*populationSize ori
                    Chromosome chromosome2 = populationList[b];     // A6 de maxGenerations*populationSize ori
                    Chromosome chromosome3 = populationList[c];     // A7 de maxGenerations*populationSize ori

                    Chromosome newChild = new Chromosome(chromosome1);          // A8 de maxGenerations*populationSize ori
                    int divisionPoint = _rand.Next(0, populationList.Count);    // A9 de maxGenerations*populationSize ori
                    for (int i = 0; i < newChild.Genes.Length; i++) // Presupunem O(1) intrucat numarul de gene este constrans intre [1,4]
                    {
                        // 3. incrucisare
                        if (_rand.NextDouble() < crossoverRate || i == divisionPoint)
                        {
                            newChild.Genes[i] = chromosome1.Genes[i] + motivationRate * (chromosome2.Genes[i] - chromosome3.Genes[i]); // A10
                        } else
                        {
                            newChild.Genes[i] = chromosome.Genes[i];    // A11
                        }
                        // A10 sau A11 se vor executa de maxGenerations*populationSize*nrGene
                    }

                    // 4. selectie
                    p.ComputeFitness(newChild); // O(1) A12 de maxGenerations*populationSize ori
                    if (newChild.Fitness >= chromosome.Fitness) 
                    {
                        newPopulationList.Add(newChild); // Complexitatea este aproximata la O(1) A13
                    } else
                    {
                        newPopulationList.Add(chromosome); // Complexitatea este aproximata la O(1) A14
                    }
                    // A13 sau A14 se vor executa de maxGenerations*populationSize
                }

                populationList = newPopulationList; // A15 de maxGenerations

                bestSolution = Selection.GetBest(populationList); // O(maxGeneration*populationSize) A16 de maxGenerations
            }

            return bestSolution; // A17
        }
        // Numarul de instructiuni efectuate : A[2+2*(populationSize)] + A[2*(populationSize+1)] + maxGenerations*(A1 + A15 + A16 + populationSize( A[2-9] + (A10||A11) + A12 + (A13||A14))) + A[(2*(maxGenerations+1)]*A[(2*(populationSize+1)]*[1-4] + A17
        // Caz favorabil are acelasi ordin de complexitate cu cazul mediu si cel nefavorabil
    }
}
