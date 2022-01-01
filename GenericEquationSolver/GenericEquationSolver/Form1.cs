using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericEquationSolver
{
    public partial class GenericEquationSolver : Form
    {
        public GenericEquationSolver()
        {
            InitializeComponent();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            /*Function f = new Function("f", "x^2 + sin(pi/4)", "x");

            MessageBox.Show(f.calculate(3).ToString());*/
            /* dummy tests */
            var f = new Function("f", textBoxEquation.Text.ToString(), "x");
            var p = new Problem(f);
            var c = p.MakeChromosome();
            p.ComputeFitness(c);
            MessageBox.Show(c.Fitness.ToString());

            textBoxResult.Text = f.calculate(3).ToString();
        }
    }
}
