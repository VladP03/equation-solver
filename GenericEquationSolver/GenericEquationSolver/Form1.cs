using org.mariuszgromada.math.mxparser;
using System;
using System.Globalization;
using System.Windows.Forms;

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
            } catch (FormatException exception)
            {
                MessageBox.Show("Number format incorrect!");
            } catch (OverflowException exception)
            {
                MessageBox.Show("Number too big!");
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void getVariablesFromTextBoxes()
        {
            populationSize = Int32.Parse(textBoxPopulationSize.Text);
            numberOfGenerations = Int32.Parse(textBoxMaxGenerations.Text);
            crossOverRate = Double.Parse(textBoxCrossoverRate.Text, CultureInfo.InvariantCulture);
            motivationRate = Double.Parse(textBoxMotivationRate.Text, CultureInfo.InvariantCulture);
        }

        private void checkVariablesBeforeSolvingEquation()
        {
            if (populationSize < 0 || numberOfGenerations < 0 || crossOverRate < 0 || motivationRate < 0)
            {
                throw new Exception("Some of variables are negative");
            }

            if (crossOverRate > 1)
            {
                throw new Exception("CrossOver Rate should be between 0 and 1");
            }

            if (motivationRate > 2)
            {
                throw new Exception("Motivation Rate should be between 0 and 2");
            }
        }

        private double solveEquation(Problem problem)
        {
            return differential.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate).Genes[0];
        }
    }
}
