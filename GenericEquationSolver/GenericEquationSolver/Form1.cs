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

        public GenericEquationSolver()
        {
            InitializeComponent();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            var function = new Function("f", textBoxEquation.Text.ToString(), "x");
            var problem = new Problem(function);

            try
            {
                getVariablesFromTextBoxes();
                checkVariablesBeforeSolvingEquation();
                textBoxResult.Text = solveEquation(problem).ToString();
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
        }

        private void checkVariablesBeforeSolvingEquation()
        {
            CheckVariableUtil.checkPopulationSize(populationSize);
            CheckVariableUtil.checkNumberOfGenerations(numberOfGenerations);
            CheckVariableUtil.checkCrossOverRate(crossOverRate);
            CheckVariableUtil.checkMotivationRate(motivationRate);
        }

        private double solveEquation(Problem problem)
        {
            return differential.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate).Genes[0];
        }
    }
}
