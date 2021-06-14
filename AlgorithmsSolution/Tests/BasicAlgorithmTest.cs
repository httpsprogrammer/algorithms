using Algoritmos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class BasicAlgorithmTest
    {
        private BasicAlgorithms basicAlgorithms = new BasicAlgorithms();

        /**********************************************************************************/
        /*SUM*/
        /**********************************************************************************/
        [TestMethod]
        public void calculateSum_WhenTheyAreNaturalNumbers_ExpectedResult()
        {
            double expected = 3;

            double result = basicAlgorithms.CalculateSum(1, 2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateSum_WhenTheyAreNegativeNumbers_ExpectedResult()
        {
            double expected = -5;

            double result = basicAlgorithms.CalculateSum(-3, -2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateSum_WhenANumberIsHexadecimal_ExpectedResult()
        {
            double expected = 17;

            double result = basicAlgorithms.CalculateSum(0x10, 1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateSum_WhenBothNumbersAreHexadecimal_ExpectedResult()
        {
            double expected = 8;

            double result = basicAlgorithms.CalculateSum(0x7, 0x1);

            Assert.AreEqual(expected, result);
        }


        /**********************************************************************************/
        /*SUBTRACTION*/
        /**********************************************************************************/
        [TestMethod]
        public void calculateSubtraction_WhenTheyAreNaturalNumbers_ExpectedResult()
        {
            int expected = -1;

            double result = basicAlgorithms.CalculateSubtraction(1, 2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateSubtraction_WhenTheyAreNegativeNumbers_ExpectedResult()
        {
            int expected = -1;

            double result = basicAlgorithms.CalculateSubtraction(-3, -2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateSubtraction_WhenANumberIsHexadecimal_ExpectedResult()
        {
            double expected = 15;

            double result = basicAlgorithms.CalculateSubtraction(0x10, 1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateSubtraction_WhenBothNumbersAreHexadecimal_ExpectedResult()
        {
            double expected = 6;

            double result = basicAlgorithms.CalculateSubtraction(0x7, 0x1);

            Assert.AreEqual(expected, result);
        }

        /**********************************************************************************/
        /*MULTIPLICATION*/
        /**********************************************************************************/
        [TestMethod]
        public void calculateMultiplication_WhenTheyAreNaturalNumbers_ExpectedResult()
        {
            double expected = 2;

            double result = basicAlgorithms.CalculateMultiplication(1, 2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateMultiplication_WhenTheyAreNegativeNumbers_ExpectedResult()
        {
            double expected = 6;

            double result = basicAlgorithms.CalculateMultiplication(-3, -2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateMultiplication_WhenANumberIsHexadecimal_ExpectedResult()
        {
            double expected = 16;

            double result = basicAlgorithms.CalculateMultiplication(0x10, 1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateMultiplication_WhenBothNumbersAreHexadecimal_ExpectedResult()
        {
            double expected = 7;

            double result = basicAlgorithms.CalculateMultiplication(0x7, 0x1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateMultiplication_WhenANumberIsZero_ExpectedResult()
        {
            double expected = 0;

            double result = basicAlgorithms.CalculateMultiplication(5, 0);

            Assert.AreEqual(expected, result);
        }

        /**********************************************************************************/
        /*DIVISION*/
        /**********************************************************************************/
        [TestMethod]
        public void calculateDivision_WhenTheyAreNaturalNumbers_ExpectedResult()
        {
            double expected = 0.5;

            double result = basicAlgorithms.CalculateDivision(1, 2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateDivision_WhenTheyAreNegativeNumbers_ExpectedResult()
        {
            double expected = 1.5;

            double result = basicAlgorithms.CalculateDivision(-3, -2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateDivision_WhenANumberIsHexadecimal_ExpectedResult()
        {
            double expected = 16;

            double result = basicAlgorithms.CalculateDivision(0x10, 1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateDivision_WhenNumeratorIsZero_ExpectedResult()
        {
            double expected = 0;

            double result = basicAlgorithms.CalculateDivision(0, 50);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateDivision_WhenNumeratorIsPositiveAndDenominatorIsZero_PositiveInfinityExpectedResult()
        {
            double expected = double.PositiveInfinity;

            double result = basicAlgorithms.CalculateDivision(2, 0);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void calculateDivision_WhenNumeratorIsNegativeAndDenominatorIsZero_NegativeInfinityExpectedResult()
        {
            double expected = double.NegativeInfinity;

            double result = basicAlgorithms.CalculateDivision(-2, 0);


            Assert.AreEqual(expected, result);
        }

        /**********************************************************************************/
        /*POWER*/
        /**********************************************************************************/
        [TestMethod]
        public void calculateExponential_WhenTheyAreNaturalNumbers_ExpectedResult()
        {
            double expected = 32;

            double result = basicAlgorithms.CalculateExponential(2, 5);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateExponential_WhenANumberIsHexadecimal_ExpectedResult()
        {
            double expected = 256;

            double result = basicAlgorithms.CalculateExponential(0x10, 2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateExponential_WhenBaseIsZero_ExpectedResult()
        {
            double expected = 0;

            double result = basicAlgorithms.CalculateExponential(0, 50);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateExponential_WhenExponentIsZero_ExpectedResult()
        {
            double expected = 1;

            double result = basicAlgorithms.CalculateExponential(2, 0);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateExponential_WhenBaseIsNegativeAndExponentialIsPositiveEvenNumber_PositiveExpectedResult()
        {
            double expected = 16;

            double result = basicAlgorithms.CalculateExponential(-2, 4);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateExponential_WhenBaseIsNegativeAndExponentialIsPositiveOddNumber_NegativeExpectedResult()
        {
            double expected = -8;

            double result = basicAlgorithms.CalculateExponential(-2, 3);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateExponential_WhenBaseIsPositiveAndExponentialIsNegativeOddNumber_ExpectedResult()
        {
            double expected = 0.125;

            double result = basicAlgorithms.CalculateExponential(2, -3);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateExponential_WhenBaseIsNegativeAndExponentialIsNegativeOddNumber_ExpectedResult()
        {
            double expected = -0.125;

            double result = basicAlgorithms.CalculateExponential(-2, -3);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateExponential_WhenBaseIsNegativeAndExponentialIsNegativeEvenNumber_ExpectedResult()
        {
            double expected = -0.25;

            double result = basicAlgorithms.CalculateExponential(-2, -2);

            Assert.AreEqual(expected, result);
        }


        /**********************************************************************************/
        /*FACTORIAL*/
        /**********************************************************************************/
        [TestMethod]
        public void calculateFactorial_WhenItsNaturalNumber_ExpectedResult()
        {
            double expected = 24;

            double result = basicAlgorithms.CalculateFactorial(4);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateFactorial_WhenItsNegativeNumber_ExpectedResult()
        {
            double expected = -1;

            double result = basicAlgorithms.CalculateFactorial(-4);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateFactorial_WhenNumberIsZero_ExpectedResult()
        {
            double expected = 1;

            double result = basicAlgorithms.CalculateFactorial(0);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void calculateFactorial_WhenNumberIsHexadecimal_ExpectedResult()
        {
            double expected = 6;

            double result = basicAlgorithms.CalculateFactorial(0x3);

            Assert.AreEqual(expected, result);
        }

        /**********************************************************************************/
        /*PALINDROME*/
        /**********************************************************************************/
        [TestMethod]
        public void palidrome_WhenAWordIsPalidrome_Correct()
        {
            bool expected = true;

            bool result = basicAlgorithms.IsPalindrome("Ana");

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void palidrome_WhenAWordHasSpaces_Correct()
        {
            bool expected = true;

            bool result = basicAlgorithms.IsPalindrome("A n a");

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void palidrome_WhenAWordIsNotAPalindrome_Correct()
        {
            bool expected = false;

            bool result = basicAlgorithms.IsPalindrome("https");

            Assert.AreEqual(expected, result);

        }
    }
}
