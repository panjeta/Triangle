using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApp18;

namespace TriangleTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
       public void Analyze_sideuserInput7_7_7_Return_Equilatral()
        {
            int firstside =7;
           int  secondside =7;
            int thirdside =7;


            string expectedoutput = "equilateral";
            string actualoutput = TriangleSolver.Analyze(firstside ,secondside ,thirdside);

            Assert.AreEqual(expectedoutput,actualoutput);
        }
        [Test]
       public void Analyze_sideuserInput13_7_7_Return_Isoceles()
        {
            int firstside = 13;
            int secondside = 7;
            int thirdside = 7;

            string expectedoutput = "isoceles";
            string actualoutput = TriangleSolver.Analyze(firstside, secondside, thirdside);

            Assert.AreEqual(expectedoutput, actualoutput);
        }
        [Test]
        public void Analyze_sideuserInput9_12_7_Return_Scalene()
        {
            int firstside = 9;
            int secondside = 12;
            int thirdside = 7;

            string expectedoutput = "scalene";
            string actualoutput = TriangleSolver.Analyze(firstside, secondside, thirdside);

            Assert.AreEqual(expectedoutput, actualoutput);
        }
        [Test]
        public  void Analyze_sideuserInput220_180_180_Return_Isoceles()
        {
            int firstside = 220;
            int secondside = 180;
            int thirdside = 180;

            string expectedoutput = "isoceles";
            string actualoutput = TriangleSolver.Analyze(firstside, secondside, thirdside);

            Assert.AreEqual(expectedoutput, actualoutput);
        }
        [Test]
        public void Analyze_sideuserInput88_88_88_Return_Equilatral()
        {
            int firstside = 88;
            int secondside = 88;
            int thirdside = 88;

            string expectedoutput = "equilateral";
            string actualoutput = TriangleSolver.Analyze(firstside, secondside, thirdside);

            Assert.AreEqual(expectedoutput, actualoutput);
        }
        [Test]
        public void Analyze_sideuserInput98_98_98_Return_Equilatral()
        {
            int firstside = 98;
            int secondside = 98;
            int thirdside = 98;

            string expectedoutput = "equilateral";
            string actualoutput = TriangleSolver.Analyze(firstside, secondside, thirdside);

            Assert.AreEqual(expectedoutput, actualoutput);
        }
        [Test]
        public void Analyze_sideuserInput15_9_9_Return_Isoceles()
        {
            int firstside = 15;
            int secondside = 9;
            int thirdside = 9;

            string expectedoutput = "isoceles";
            string actualoutput = TriangleSolver.Analyze(firstside, secondside, thirdside);

            Assert.AreEqual(expectedoutput, actualoutput);
        }
        [Test]
        public void Analyze_sideuserInput13_17_12_Return_Scalene()
        {
            int firstside = 13;
            int secondside = 17;
            int thirdside = 12;

            string expectedoutput = "scalene";
            string actualoutput = TriangleSolver.Analyze(firstside, secondside, thirdside);

            Assert.AreEqual(expectedoutput, actualoutput);
        }


    }
}
