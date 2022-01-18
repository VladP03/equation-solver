using org.mariuszgromada.math.mxparser;
using System;
using System.Windows.Forms;
using CustomExceptions;
using ParseVariable;
using CheckVariables;
using System.Collections.Generic;

namespace GenericEquationSolver
{
    public partial class GenericEquationSolver : Form
    {
        private DifferentialEvolutionaryAlgorithm differential = new DifferentialEvolutionaryAlgorithm();

        private int populationSize;
        private int numberOfGenerations;
        private double crossOverRate;
        private double motivationRate;
        private int numOfGenes;
        private int minGeneValue;
        private int maxGeneValue;

        public GenericEquationSolver()
        {
            InitializeComponent();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            var function = new Function("f", textBoxEquation.Text.ToString(), "x");

            try
            {
                getVariablesFromTextBoxes();
                var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue);
                textBoxResult.Text = solveEquation(problem);
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void getVariablesFromTextBoxes()
        {
            try
            {
                populationSize = ParseVariableUtil.parseIntoIntegerFromTextbox(textBoxPopulationSize.Text);
                CheckVariableUtil.checkPopulationSize(populationSize);
            } catch (Exception exception)
            {
                throw new Exception(exception.Message + "\r\nOn Population Size field");
            }

            try
            {
                numberOfGenerations = ParseVariableUtil.parseIntoIntegerFromTextbox(textBoxMaxGenerations.Text);
                CheckVariableUtil.checkNumberOfGenerations(numberOfGenerations);
            } catch (Exception exception)
            {
                throw new Exception(exception.Message + "\r\nOn Max Generations field");
            }

            try
            {
                crossOverRate = ParseVariableUtil.parseIntoDoubleFromTextbox(textBoxCrossoverRate.Text);
                CheckVariableUtil.checkCrossOverRate(crossOverRate);
            } catch (Exception exception)
            {
                throw new Exception(exception.Message + "\r\nOn CrossOver Rate field");
            }

            try
            {
                motivationRate = ParseVariableUtil.parseIntoDoubleFromTextbox(textBoxMotivationRate.Text);
                CheckVariableUtil.checkMotivationRate(motivationRate);
            } catch (Exception exception)
            {
                throw new Exception(exception.Message + "\r\nOn Motivation Rate field");
            }

            try
            {
                numOfGenes = ParseVariableUtil.parseIntoIntegerFromTextbox(textBoxNumOfSolutions.Text);
                CheckVariableUtil.checkNumOfGenes(numOfGenes);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message + "\r\nOn Num Of Genes field");
            }

            try
            {
                minGeneValue = ParseVariableUtil.parseIntoIntegerFromTextbox(textBoxMinGeneValue.Text);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message + "\r\nOn Min Gene Value field");
            }

            try
            {
                maxGeneValue = ParseVariableUtil.parseIntoIntegerFromTextbox(textBoxMaxGeneValue.Text);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message + "\r\nOn Max Gene Value field");
            }
        }

        private string solveEquation(IOptimizationProblem problem)
        {
            Chromosome bestChromosome = differential.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            string solutions = "";
            foreach(var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            return solutions;
        }

        private void buttonStatisticalAnalysis_Click(object sender, EventArgs e)
        {
            var function = new Function("f", textBoxEquation.Text.ToString(), "x");

            try
            {
                getVariablesFromTextBoxes();
                MessageBox.Show("Please note that correctness is guaranteed only for single solution equations!! Otherwise standard deviation will clearly be different than 0.");
                var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue);
                List<double> results = new List<double>();
                double dispersion = 0;
                double mean = 0;
                double standardDeviation;

                for (int i = 0; i < 100; ++i)
                {
                    results.Add(differential.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate).Genes[0]);
                }

                foreach (double solution in results)
                {
                    mean += solution;
                }

                mean /= results.Count;

                foreach (double solution in results)
                {
                    dispersion += Math.Pow(solution - mean, 2);
                }

                dispersion /= results.Count;
                standardDeviation = Math.Sqrt(dispersion);

                textBoxResult.Text = $"Standard deviation after running 100 times the algorithm for the given equation: {standardDeviation}" ;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
;