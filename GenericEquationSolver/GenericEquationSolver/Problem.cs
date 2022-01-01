using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEquationSolver
{
    class Problem : IOptimizationProblem
    {
        Function _equationFunction;
        public Problem(Function targetFunction)
        {
            _equationFunction = targetFunction;
        }

        public void ComputeFitness(Chromosome c)
        {
            c.Fitness = -Math.Abs(_equationFunction.calculate(c.Genes[0]));
        }

        public Chromosome MakeChromosome()
        {
            // to be replaced with user input
            return new Chromosome(1, new double[] { -5 }, new double[] { 5 });
        }
    }
}
