
namespace GenericEquationSolver
{
    partial class GenericEquationSolver
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSolve = new System.Windows.Forms.Button();
            this.textBoxEquation = new System.Windows.Forms.TextBox();
            this.textBoxPopulationSize = new System.Windows.Forms.TextBox();
            this.textBoxMaxGenerations = new System.Windows.Forms.TextBox();
            this.textBoxCrossoverRate = new System.Windows.Forms.TextBox();
            this.textBoxMotivationRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxEquation = new System.Windows.Forms.GroupBox();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.groupBoxLimits = new System.Windows.Forms.GroupBox();
            this.minGeneValueLabel = new System.Windows.Forms.Label();
            this.maxGeneValueLabel = new System.Windows.Forms.Label();
            this.textBoxMaxGeneValue = new System.Windows.Forms.TextBox();
            this.textBoxMinGeneValue = new System.Windows.Forms.TextBox();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.textBoxNumOfSolutions = new System.Windows.Forms.TextBox();
            this.numOfSolutionsLabel = new System.Windows.Forms.Label();
            this.groupBoxEquation.SuspendLayout();
            this.groupBoxParameters.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxLimits.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSolve
            // 
            this.buttonSolve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.buttonSolve.Location = new System.Drawing.Point(232, 290);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(132, 23);
            this.buttonSolve.TabIndex = 0;
            this.buttonSolve.Text = "Solve";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // textBoxEquation
            // 
            this.textBoxEquation.Location = new System.Drawing.Point(6, 22);
            this.textBoxEquation.Name = "textBoxEquation";
            this.textBoxEquation.Size = new System.Drawing.Size(287, 22);
            this.textBoxEquation.TabIndex = 1;
            this.textBoxEquation.Text = "x^2 - 4";
            // 
            // textBoxPopulationSize
            // 
            this.textBoxPopulationSize.Location = new System.Drawing.Point(147, 22);
            this.textBoxPopulationSize.Name = "textBoxPopulationSize";
            this.textBoxPopulationSize.Size = new System.Drawing.Size(96, 22);
            this.textBoxPopulationSize.TabIndex = 2;
            this.textBoxPopulationSize.Text = "100";
            // 
            // textBoxMaxGenerations
            // 
            this.textBoxMaxGenerations.Location = new System.Drawing.Point(147, 55);
            this.textBoxMaxGenerations.Name = "textBoxMaxGenerations";
            this.textBoxMaxGenerations.Size = new System.Drawing.Size(96, 22);
            this.textBoxMaxGenerations.TabIndex = 3;
            this.textBoxMaxGenerations.Text = "100";
            // 
            // textBoxCrossoverRate
            // 
            this.textBoxCrossoverRate.Location = new System.Drawing.Point(147, 92);
            this.textBoxCrossoverRate.Name = "textBoxCrossoverRate";
            this.textBoxCrossoverRate.Size = new System.Drawing.Size(96, 22);
            this.textBoxCrossoverRate.TabIndex = 4;
            this.textBoxCrossoverRate.Text = "0.9";
            // 
            // textBoxMotivationRate
            // 
            this.textBoxMotivationRate.Location = new System.Drawing.Point(147, 129);
            this.textBoxMotivationRate.Name = "textBoxMotivationRate";
            this.textBoxMotivationRate.Size = new System.Drawing.Size(96, 22);
            this.textBoxMotivationRate.TabIndex = 5;
            this.textBoxMotivationRate.Text = "0.8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Population Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max Generations:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Crossover Rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Motivation Rate:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(6, 21);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(293, 70);
            this.textBoxResult.TabIndex = 0;
            // 
            // groupBoxEquation
            // 
            this.groupBoxEquation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.groupBoxEquation.Controls.Add(this.textBoxEquation);
            this.groupBoxEquation.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxEquation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEquation.Name = "groupBoxEquation";
            this.groupBoxEquation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxEquation.Size = new System.Drawing.Size(305, 64);
            this.groupBoxEquation.TabIndex = 13;
            this.groupBoxEquation.TabStop = false;
            this.groupBoxEquation.Text = "Equation - f(x) from f(x) = 0";
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.groupBoxParameters.Controls.Add(this.label2);
            this.groupBoxParameters.Controls.Add(this.textBoxPopulationSize);
            this.groupBoxParameters.Controls.Add(this.textBoxMaxGenerations);
            this.groupBoxParameters.Controls.Add(this.label5);
            this.groupBoxParameters.Controls.Add(this.textBoxCrossoverRate);
            this.groupBoxParameters.Controls.Add(this.label4);
            this.groupBoxParameters.Controls.Add(this.textBoxMotivationRate);
            this.groupBoxParameters.Controls.Add(this.label3);
            this.groupBoxParameters.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxParameters.Location = new System.Drawing.Point(323, 12);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(249, 171);
            this.groupBoxParameters.TabIndex = 15;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Parameters";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.groupBoxResult.Controls.Add(this.textBoxResult);
            this.groupBoxResult.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxResult.Location = new System.Drawing.Point(12, 83);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(305, 100);
            this.groupBoxResult.TabIndex = 14;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Result";
            // 
            // groupBoxLimits
            // 
            this.groupBoxLimits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.groupBoxLimits.Controls.Add(this.minGeneValueLabel);
            this.groupBoxLimits.Controls.Add(this.maxGeneValueLabel);
            this.groupBoxLimits.Controls.Add(this.textBoxMaxGeneValue);
            this.groupBoxLimits.Controls.Add(this.textBoxMinGeneValue);
            this.groupBoxLimits.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxLimits.Location = new System.Drawing.Point(12, 196);
            this.groupBoxLimits.Name = "groupBoxLimits";
            this.groupBoxLimits.Size = new System.Drawing.Size(305, 81);
            this.groupBoxLimits.TabIndex = 15;
            this.groupBoxLimits.TabStop = false;
            this.groupBoxLimits.Text = "Limits";
            // 
            // minGeneValueLabel
            // 
            this.minGeneValueLabel.AutoSize = true;
            this.minGeneValueLabel.Location = new System.Drawing.Point(15, 24);
            this.minGeneValueLabel.Name = "minGeneValueLabel";
            this.minGeneValueLabel.Size = new System.Drawing.Size(127, 16);
            this.minGeneValueLabel.TabIndex = 14;
            this.minGeneValueLabel.Text = "Min gene value:";
            // 
            // maxGeneValueLabel
            // 
            this.maxGeneValueLabel.AutoSize = true;
            this.maxGeneValueLabel.Location = new System.Drawing.Point(15, 49);
            this.maxGeneValueLabel.Name = "maxGeneValueLabel";
            this.maxGeneValueLabel.Size = new System.Drawing.Size(127, 16);
            this.maxGeneValueLabel.TabIndex = 13;
            this.maxGeneValueLabel.Text = "Max gene value:";
            // 
            // textBoxMaxGeneValue
            // 
            this.textBoxMaxGeneValue.Location = new System.Drawing.Point(176, 49);
            this.textBoxMaxGeneValue.Name = "textBoxMaxGeneValue";
            this.textBoxMaxGeneValue.Size = new System.Drawing.Size(96, 22);
            this.textBoxMaxGeneValue.TabIndex = 11;
            this.textBoxMaxGeneValue.Text = "5";
            // 
            // textBoxMinGeneValue
            // 
            this.textBoxMinGeneValue.Location = new System.Drawing.Point(176, 21);
            this.textBoxMinGeneValue.Name = "textBoxMinGeneValue";
            this.textBoxMinGeneValue.Size = new System.Drawing.Size(96, 22);
            this.textBoxMinGeneValue.TabIndex = 12;
            this.textBoxMinGeneValue.Text = "-5";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(64)))));
            this.groupBoxOptions.Controls.Add(this.textBoxNumOfSolutions);
            this.groupBoxOptions.Controls.Add(this.numOfSolutionsLabel);
            this.groupBoxOptions.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxOptions.Location = new System.Drawing.Point(323, 196);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(249, 81);
            this.groupBoxOptions.TabIndex = 16;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // textBoxNumOfSolutions
            // 
            this.textBoxNumOfSolutions.Location = new System.Drawing.Point(179, 33);
            this.textBoxNumOfSolutions.Name = "textBoxNumOfSolutions";
            this.textBoxNumOfSolutions.Size = new System.Drawing.Size(21, 22);
            this.textBoxNumOfSolutions.TabIndex = 15;
            this.textBoxNumOfSolutions.Text = "1";
            // 
            // numOfSolutionsLabel
            // 
            this.numOfSolutionsLabel.AutoSize = true;
            this.numOfSolutionsLabel.Location = new System.Drawing.Point(27, 36);
            this.numOfSolutionsLabel.Name = "numOfSolutionsLabel";
            this.numOfSolutionsLabel.Size = new System.Drawing.Size(135, 16);
            this.numOfSolutionsLabel.TabIndex = 16;
            this.numOfSolutionsLabel.Text = "Number of genes:";
            // 
            // GenericEquationSolver
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(582, 324);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBoxLimits);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxEquation);
            this.Controls.Add(this.buttonSolve);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GenericEquationSolver";
            this.Text = "Generic Equation Solver";
            this.groupBoxEquation.ResumeLayout(false);
            this.groupBoxEquation.PerformLayout();
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxLimits.ResumeLayout(false);
            this.groupBoxLimits.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.TextBox textBoxEquation;
        private System.Windows.Forms.TextBox textBoxPopulationSize;
        private System.Windows.Forms.TextBox textBoxMaxGenerations;
        private System.Windows.Forms.TextBox textBoxCrossoverRate;
        private System.Windows.Forms.TextBox textBoxMotivationRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBoxEquation;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.GroupBox groupBoxLimits;
        private System.Windows.Forms.Label minGeneValueLabel;
        private System.Windows.Forms.Label maxGeneValueLabel;
        private System.Windows.Forms.TextBox textBoxMaxGeneValue;
        private System.Windows.Forms.TextBox textBoxMinGeneValue;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.TextBox textBoxNumOfSolutions;
        private System.Windows.Forms.Label numOfSolutionsLabel;
    }
}

