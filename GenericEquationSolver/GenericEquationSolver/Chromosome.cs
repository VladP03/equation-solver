using System;

namespace GenericEquationSolver
{
    /// <summary>
    /// Clasa care reprezinta un individ din populatie
    /// </summary>
    public class Chromosome
    {
        public int NoGenes { get; set; } // numarul de gene ale individului

        public double[] Genes { get; set; } // valorile genelor

        public double[] MinValues { get; set; } // valorile minime posibile ale genelor

        public double[] MaxValues { get; set; } // valorile maxime posibile ale genelor

        public double Fitness { get; set; } // valoarea functiei de adaptare a individului

        private static Random _rand = new Random();

        public Chromosome(int noGenes, double minValue, double maxValue)
        {
            NoGenes = noGenes;
            Genes = new double[noGenes];
            MinValues = new double[noGenes];
            MaxValues = new double[noGenes];

            for (int i = 0; i < noGenes; i++)
            {
                MinValues[i] = minValue;
                MaxValues[i] = maxValue;

                Genes[i] = MinValues[i] + _rand.NextDouble() * (MaxValues[i] - MinValues[i]); // initializare aleatorie a genelor
            }
        }

        public Chromosome(Chromosome c) // constructor de copiere
        {
            NoGenes = c.NoGenes;
            Fitness = c.Fitness;

            Genes = new double[c.NoGenes];
            MinValues = new double[c.NoGenes];
            MaxValues = new double[c.NoGenes];

            for (int i = 0; i < c.Genes.Length; i++)
            {
                Genes[i] = c.Genes[i];
                MinValues[i] = c.MinValues[i];
                MaxValues[i] = c.MaxValues[i];
            }
        }
    }
}
