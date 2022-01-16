using GenericEquationSolver;
using NUnit.Framework;
using CustomExceptions;

namespace UnitTest
{
    public class Tests
    {
        DifferentialEvolutionaryAlgorithm dea = new DifferentialEvolutionaryAlgorithm();
        int numOfGenes;
        int minGeneValue;
        int maxGeneValue;
        int populationSize;
        int numberOfGenerations;
        double crossOverRate;
        double motivationRate;

        [Test]
        public void TestEq_1()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("f", "x-1", "x");
            numOfGenes =1;
            minGeneValue = -5;
            maxGeneValue = 5;
            populationSize = 100;
            numberOfGenerations = 100;
            crossOverRate = 0.9;
            motivationRate = 0.8;
            var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, false);
            Chromosome bestChromosome = dea.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            string solutions = "";
            foreach (var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            System.Console.WriteLine("Raspuns corect: 1");
            System.Console.WriteLine(solutions);
            Assert.AreEqual(1,bestChromosome.Genes[0],0.01);
        }

        [Test]
        public void TestEq_2()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("f", "x^2-4", "x");
            numOfGenes = 2;
            minGeneValue = -5;
            maxGeneValue = 5;
            populationSize = 100;
            numberOfGenerations = 100;
            crossOverRate = 0.9;
            motivationRate = 0.8;
            var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, false);
            Chromosome bestChromosome = dea.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            System.Array.Sort(bestChromosome.Genes);
            string solutions = "";
            foreach (var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            System.Console.WriteLine("Raspuns corect: {-2, 2}");
            System.Console.WriteLine(solutions);
            Assert.AreEqual(-2, bestChromosome.Genes[0], 0.01);
            Assert.AreEqual(2, bestChromosome.Genes[1], 0.01);
        }

        [Test]
        public void TestEq_3()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("f", "x^3-125", "x");
            numOfGenes = 3;
            minGeneValue = -5;
            maxGeneValue = 5;
            populationSize = 100;
            numberOfGenerations = 100;
            crossOverRate = 0.9;
            motivationRate = 0.8;
            var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, false);
            Chromosome bestChromosome = dea.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            System.Array.Sort(bestChromosome.Genes);
            string solutions = "";
            foreach (var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            System.Console.WriteLine("Raspuns corect: 5");
            System.Console.WriteLine(solutions);
            for (int i = 0; i < numOfGenes; ++i)
            {
                Assert.AreEqual(5, bestChromosome.Genes[i], 0.01);
            }
        }

        [Test]
        public void TestEq_4()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("f", "x^5-3*x^3+15*x-4", "x");
            numOfGenes = 5;
            minGeneValue = -5;
            maxGeneValue = 5;
            populationSize = 100;
            numberOfGenerations = 100;
            crossOverRate = 0.9;
            motivationRate = 0.8;
            var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, false);
            Chromosome bestChromosome = dea.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            string solutions = "";
            foreach (var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            System.Console.WriteLine("Raspuns corect: 0.27050");
            System.Console.WriteLine(solutions);
            for (int i = 0; i < numOfGenes; ++i)
            {
                Assert.AreEqual(0.2705, bestChromosome.Genes[i], 0.03);
            }
        }

        [Test]
        public void TestEq_4_LessGeneration()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("f", "x^5-3*x^3+15*x-4", "x");
            numOfGenes = 5;
            minGeneValue = -5;
            maxGeneValue = 5;
            populationSize = 100;
            numberOfGenerations = 50;
            crossOverRate = 0.9;
            motivationRate = 0.8;
            var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, false);
            Chromosome bestChromosome = dea.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            string solutions = "";
            foreach (var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            System.Console.WriteLine("Raspuns corect: 0.27050");
            System.Console.WriteLine(solutions);
            for (int i = 0; i < numOfGenes; ++i)
            {
                Assert.AreEqual(0.2705, bestChromosome.Genes[i], 0.35);
            }
        }

        [Test]
        public void TestEq_4_SmallerPopulation()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("f", "x^5-3*x^3+15*x-4", "x");
            numOfGenes = 5;
            minGeneValue = -5;
            maxGeneValue = 5;
            populationSize = 25;
            numberOfGenerations = 100;
            crossOverRate = 0.9;
            motivationRate = 0.8;
            var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, false);
            Chromosome bestChromosome = dea.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            string solutions = "";
            foreach (var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            System.Console.WriteLine("Raspuns corect: 0.27050");
            System.Console.WriteLine(solutions);
            for (int i = 0; i < numOfGenes; ++i)
            {
                Assert.AreEqual(0.2705, bestChromosome.Genes[i], 0.1);
            }
        }

        [Test]
        public void TestEq_4_DecreaseCrossOverRate()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("f", "x^5-3*x^3+15*x-4", "x");
            numOfGenes = 5;
            minGeneValue = -5;
            maxGeneValue = 5;
            populationSize = 100;
            numberOfGenerations = 100;
            crossOverRate = 0.6;
            motivationRate = 0.8;
            var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, false);
            Chromosome bestChromosome = dea.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            string solutions = "";
            foreach (var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            System.Console.WriteLine("Raspuns corect: 0.27050");
            System.Console.WriteLine(solutions);
            for (int i = 0; i < numOfGenes; ++i)
            {
                Assert.AreEqual(0.2705, bestChromosome.Genes[i], 0.1);
            }
        }

        [Test]
        public void TestEq_4_DecreaseMotivationRate()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("f", "x^5-3*x^3+15*x-4", "x");
            numOfGenes = 5;
            minGeneValue = -5;
            maxGeneValue = 5;
            populationSize = 100;
            numberOfGenerations = 100;
            crossOverRate = 0.9;
            motivationRate = 0.4;
            var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, false);
            Chromosome bestChromosome = dea.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            string solutions = "";
            foreach (var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            System.Console.WriteLine("Raspuns corect: 0.27050");
            System.Console.WriteLine(solutions);
            for (int i = 0; i < numOfGenes; ++i)
            {
                Assert.AreEqual(0.2705, bestChromosome.Genes[i], 0.1);
            }
        }

        [Test]
        public void TestEq_4_Random1()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("f", "x^5-3*x^3+15*x-4", "x");
            numOfGenes = 5;
            minGeneValue = -5;
            maxGeneValue = 5;
            populationSize = 75;
            numberOfGenerations = 150;
            crossOverRate = 0.75;
            motivationRate = 0.7;
            var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, false);
            Chromosome bestChromosome = dea.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            string solutions = "";
            foreach (var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            System.Console.WriteLine("Raspuns corect: 0.27050");
            System.Console.WriteLine(solutions);
            for (int i = 0; i < numOfGenes; ++i)
            {
                Assert.AreEqual(0.2705, bestChromosome.Genes[i], 0.1);
            }
        }

        [Test]
        public void TestEq_4_Random2()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("f", "x^5-3*x^3+15*x-4", "x");
            numOfGenes = 5;
            minGeneValue = -5;
            maxGeneValue = 5;
            populationSize = 50;
            numberOfGenerations = 50;
            crossOverRate = 0.6;
            motivationRate = 0.9;
            var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, false);
            Chromosome bestChromosome = dea.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            string solutions = "";
            foreach (var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            System.Console.WriteLine("Raspuns corect: 0.27050");
            System.Console.WriteLine(solutions);
            for(int i=0;i<numOfGenes;++i)
            {
                Assert.AreEqual(0.2705, bestChromosome.Genes[i], 0.4);
            }
        }

        [Test]
        public void TestEq_4_Random3()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("f", "x^5-3*x^3+15*x-4", "x");
            numOfGenes = 5;
            minGeneValue = -5;
            maxGeneValue = 5;
            populationSize = 250;
            numberOfGenerations = 50;
            crossOverRate = 0.8;
            motivationRate = 0.3;
            var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, false);
            Chromosome bestChromosome = dea.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            string solutions = "";
            foreach (var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            System.Console.WriteLine("Raspuns corect: 0.27050");
            System.Console.WriteLine(solutions);
            for (int i = 0; i < numOfGenes; ++i)
            {
                Assert.AreEqual(0.2705, bestChromosome.Genes[i], 0.15);
            }
        }

        [Test]
        public void TestEuler()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("f", "e^x - 7.3890560", "x");
            numOfGenes = 1;
            minGeneValue = -5;
            maxGeneValue = 5;
            populationSize = 100;
            numberOfGenerations = 100;
            crossOverRate = 0.9;
            motivationRate = 0.8;
            var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, false);
            Chromosome bestChromosome = dea.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            string solutions = "";
            foreach (var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            System.Console.WriteLine("Raspuns corect: 2");
            System.Console.WriteLine(solutions);
            Assert.AreEqual(2, bestChromosome.Genes[0], 0.01);

        }

        [Test]
        public void TestPi()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("f", "e^pi-x", "x");
            numOfGenes = 1;
            minGeneValue = -5;
            maxGeneValue = 5;
            populationSize = 100;
            numberOfGenerations = 100;
            crossOverRate = 0.9;
            motivationRate = 0.8;
            var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, false);
            Chromosome bestChromosome = dea.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            string solutions = "";
            foreach (var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            System.Console.WriteLine("Raspuns corect: 23.14");
            System.Console.WriteLine(solutions);
            Assert.AreEqual(23.14, bestChromosome.Genes[0], 0.01);

        }

        [Test]
        public void TestCombinat()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("f", "e^pi-x^2+3*x-log2(x)+5", "x");
            numOfGenes = 2;
            minGeneValue = -5;
            maxGeneValue = 5;
            populationSize = 100;
            numberOfGenerations = 100;
            crossOverRate = 0.9;
            motivationRate = 0.8;
            var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, false);
            Chromosome bestChromosome = dea.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            string solutions = "";
            foreach (var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            System.Console.WriteLine("Raspuns corect: 6.756");
            System.Console.WriteLine(solutions);
            Assert.AreEqual(6.756, bestChromosome.Genes[0], 0.2);
        }

        [Test]
        public void TestLog1()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("f", "log2(x)+log2(x^2)-16", "x");
            numOfGenes = 1;
            minGeneValue = -5;
            maxGeneValue = 5;
            populationSize = 100;
            numberOfGenerations = 100;
            crossOverRate = 0.9;
            motivationRate = 0.8;
            var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, false);
            Chromosome bestChromosome = dea.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            string solutions = "";
            foreach (var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            System.Console.WriteLine("Raspuns corect: 40.317");
            System.Console.WriteLine(solutions);
            Assert.AreEqual(40.317, bestChromosome.Genes[0], 0.01);
        }

        [Test]
        public void TestLog2()
        {
            var function = new org.mariuszgromada.math.mxparser.Function("f", "log2(x^3)-42", "x");
            numOfGenes = 1;
            minGeneValue = -5;
            maxGeneValue = 5;
            populationSize = 100;
            numberOfGenerations = 500;
            crossOverRate = 0.9;
            motivationRate = 0.8;
            var problem = new Problem(function, numOfGenes, minGeneValue, maxGeneValue, false);
            Chromosome bestChromosome = dea.Solve(problem, populationSize, numberOfGenerations, crossOverRate, motivationRate);
            string solutions = "";
            foreach (var gene in bestChromosome.Genes)
            {
                solutions += $"{gene.ToString()}\r\n";
            }
            System.Console.WriteLine("Raspuns corect: 16384");
            System.Console.WriteLine(solutions);
            Assert.AreEqual(16384, bestChromosome.Genes[0], 10);
        }

        [Test]
        public void TestNegativePopulationSize()
        {
            populationSize = -10;
            Assert.Throws<CustomExceptions.NegativeOrZeroNumberException>(delegate { CheckVariables.CheckVariableUtil.checkPopulationSize(populationSize); });
        }

        [Test]
        public void TestNegativeNumberOfGeneration()
        {
            numberOfGenerations = -10;
            Assert.Throws<CustomExceptions.NegativeOrZeroNumberException>(delegate { CheckVariables.CheckVariableUtil.checkNumberOfGenerations(numberOfGenerations); });
        }

        [Test]
        public void TestNegativeCrossOverRate()
        {
            crossOverRate = -0.5;
            Assert.Throws<CustomExceptions.CrossOverRateException>(delegate { CheckVariables.CheckVariableUtil.checkCrossOverRate(crossOverRate); });
        }

        [Test]
        public void TestOver1CrossOverRate()
        {
            crossOverRate = 1.1;
            Assert.Throws<CustomExceptions.CrossOverRateException>(delegate { CheckVariables.CheckVariableUtil.checkCrossOverRate(crossOverRate); });
        }

        [Test]
        public void TestNegativeMotivationRate()
        {
            motivationRate = -1;
            Assert.Throws<CustomExceptions.MotivationRateException>(delegate { CheckVariables.CheckVariableUtil.checkMotivationRate(motivationRate); });
        }

        [Test]
        public void TestOver2MotivationRate()
        {
            motivationRate = 2.5;
            Assert.Throws<CustomExceptions.MotivationRateException>(delegate { CheckVariables.CheckVariableUtil.checkMotivationRate(motivationRate); });
        }

        [Test]
        public void TestNegativeNumOfGenes()
        {
            numOfGenes = -1;
            Assert.Throws<CustomExceptions.NegativeOrZeroNumberException>(delegate { CheckVariables.CheckVariableUtil.checkNumOfGenes(numOfGenes); });
        }

        [Test]
        public void TestOver9NumOfGenes()
        {
            numOfGenes = 10;
            Assert.Throws<CustomExceptions.NegativeOrZeroNumberException>(delegate { CheckVariables.CheckVariableUtil.checkNumOfGenes(numOfGenes); });
        }
    }
}