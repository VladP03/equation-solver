using org.mariuszgromada.math.mxparser;
using System;
using System.Windows.Forms;
using CustomExceptions;
using ParseVariable;
using CheckVariables;

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
        private bool willLookForComplexSolutions;

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
                var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, willLookForComplexSolutions);
                checkVariablesBeforeSolvingEquation();
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
            } catch (Exception exception)
            {
                throw new Exception(exception.Message + "\r\nOn Population Size field");
            }

            try
            {
                numberOfGenerations = ParseVariableUtil.parseIntoIntegerFromTextbox(textBoxMaxGenerations.Text);
            } catch (Exception exception)
            {
                throw new Exception(exception.Message + "\r\nOn Max Generations field");
            }

            try
            {
                crossOverRate = ParseVariableUtil.parseIntoDoubleFromTextbox(textBoxCrossoverRate.Text);
            } catch (Exception exception)
            {
                throw new Exception(exception.Message + "\r\nOn CrossOver Rate field");
            }

            try
            {
                motivationRate = ParseVariableUtil.parseIntoDoubleFromTextbox(textBoxMotivationRate.Text);
            } catch (Exception exception)
            {
                throw new Exception(exception.Message + "\r\nOn Motivation Rate field");
            }

            try
            {
                numOfGenes = ParseVariableUtil.parseIntoIntegerFromTextbox(textBoxNumOfSolutions.Text);
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

        private void checkVariablesBeforeSolvingEquation()
        {
            CheckVariableUtil.checkPopulationSize(populationSize);
            CheckVariableUtil.checkNumberOfGenerations(numberOfGenerations);
            CheckVariableUtil.checkCrossOverRate(crossOverRate);
            CheckVariableUtil.checkMotivationRate(motivationRate);
            CheckVariableUtil.checkNumOfGenes(numOfGenes);
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

        private void minGeneValueLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
;