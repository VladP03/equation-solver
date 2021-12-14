using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEquationSolver
{
    class Problem : IOptimizationProblem
    {
        Func<double> equationFunction;
        public Problem(string equationString)
        {
            // trebuie sa gandim o metoda de a parsa o functie de grad n dintr-un string
        }

        public void ComputeFitness(Chromosome c)
        {
            throw new NotImplementedException();
        }

        public Chromosome MakeChromosome()
        {
            throw new NotImplementedException();
        }
    }
}
