namespace GenericEquationSolver
{
    /// <summary>
    /// Interfata pentru problemele de optimizare
    /// </summary>
    public interface IOptimizationProblem
    {
        void ComputeFitness(Chromosome c);

        Chromosome MakeChromosome();
    }
}
