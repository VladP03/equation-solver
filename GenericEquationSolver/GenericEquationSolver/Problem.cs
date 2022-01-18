using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEquationSolver
{
    public class Problem : IOptimizationProblem
    {
        Function _equationFunction;
        int _numOfSolutions;
        int _minGeneVal;
        int _maxGeneVal;

        public Problem(Function targetFunction, int numOfSolutions, int minGeneVal, int maxGeneVal)
        {
            _equationFunction = targetFunction;
            _numOfSolutions = numOfSolutions;
            _minGeneVal = minGeneVal;
            _maxGeneVal = maxGeneVal;
        }

        // Considerand faptul ca nr de gene este constrans intre valorile din intervalul [1,4], complexitatea apartine clasei O(1)
        public void ComputeFitness(Chromosome c)
        {
            double summed = 0;
            double dispersion = 0;
            double standardDeviation ;
            double meanGeneVal = 0;

            if(c.Genes.Length > 0)
            {
                foreach (var gene in c.Genes)
                {
                    summed += -Math.Abs(_equationFunction.calculate(gene));
                    meanGeneVal += gene;
                }
                double meanFitness = summed / c.Genes.Length;
                meanGeneVal /= c.Genes.Length;

                foreach (var gene in c.Genes)
                {
                    dispersion += Math.Pow(gene - meanGeneVal, 2);
                }

                dispersion /= c.Genes.Length;
                standardDeviation = Math.Sqrt(dispersion);

                c.Fitness = 0.90 * meanFitness + 0.10 * standardDeviation;
            }
            else
            {
                c.Fitness = -Math.Abs(_equationFunction.calculate(c.Genes[0]));
            }

        }

        public Chromosome MakeChromosome()
        {
            // to be replaced with user input
            return new Chromosome(_numOfSolutions, _minGeneVal , _maxGeneVal );
        }
    }
}
