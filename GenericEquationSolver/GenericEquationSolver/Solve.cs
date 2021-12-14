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

        public static Chromosome Tournament(Chromosome[] population)
        {
            throw new Exception("Aceasta metoda trebuie implementata");
        }

        public static Chromosome GetBest(Chromosome[] population)
        {
            throw new Exception("Aceasta metoda trebuie implementata");
        }
    }

    //==================================================================================

    /// <summary>
    /// Clasa care reprezinta operatia de incrucisare
    /// </summary>
    public class Crossover
    {
        private static Random _rand = new Random();

        public static Chromosome Arithmetic(Chromosome mother, Chromosome father, double rate)
        {
            throw new Exception("Aceasta metoda trebuie implementata");
        }
    }

    //==================================================================================

    /// <summary>
    /// Clasa care reprezinta operatia de mutatie
    /// </summary>
    public class Mutation
    {
        private static Random _rand = new Random();

        public static void Reset(Chromosome child, double rate)
        {
            throw new Exception("Aceasta metoda trebuie implementata");
        }
    }

    //==================================================================================

    /// <summary>
    /// Clasa care implementeaza algoritmul evolutiv pentru optimizare
    /// </summary>
    public class DifferentialEvolutionaryAlgorithm
    {
        /// <summary>
        /// Metoda de optimizare care gaseste solutia problemei
        /// </summary>
        public Chromosome Solve(IOptimizationProblem p, int populationSize, int maxGenerations, double crossoverRate, double motivationRate)
        {
            throw new Exception("Aceasta metoda trebuie completata");
        }
    }
}
