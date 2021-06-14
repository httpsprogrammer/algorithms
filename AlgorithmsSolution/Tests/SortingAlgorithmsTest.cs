using Algoritmos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Linq;

namespace Tests
{

    [TestClass]
    public class SortingAlgorithmsTest
    {
        private SortingAlgorithms shorting = new SortingAlgorithms();

        /**********************************************************************************/
        /*BUBBLE SORT*/
        /**********************************************************************************/
        [TestMethod]
        public void BubbleSort_WhenValuesAreAlreadySorted_ExpectedResult()
        {
            int[] expected = { -5, -2, 1, 2, 3, 4, 5, 11, 20, 80, 100 };
            int[] array = { -5, -2, 1, 2, 3, 4, 5, 11, 20, 80, 100 };

            int[] result = shorting.BubbleSort(array);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void BubbleSort_WhenValuesAreUntidy_ExpectedResult()
        {
            int[] expected = { -5, -2, 1, 2, 3, 4, 5, 11, 20, 80, 100 };
            int[] array = { 11, 3, 4, 1, 5, 20, 2, 100, 80, -5, -2 };

            int[] result = shorting.BubbleSort(array);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        /**********************************************************************************/
        /*Cocktail Sort SORT*/
        /**********************************************************************************/
        [TestMethod]
        public void CocktailSort_WhenValuesAreAlreadySorted_ExpectedResult()
        {
            int[] expected = { -5, -2, 1, 2, 3, 4, 5, 11, 20, 80, 100 };
            int[] array = { -5, -2, 1, 2, 3, 4, 5, 11, 20, 80, 100 };

            int[] result = shorting.CocktailSort(array);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void CocktailSort_WhenValuesAreUntidy_ExpectedResult()
        {
            int[] expected = { -5, -2, 1, 2, 3, 4, 5, 11, 20, 80, 100 };
            int[] array = { 80, 11, 3, 2, 1, 5, 20, 100, 4, -5, -2 };

            int[] result = shorting.CocktailSort(array);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        /**********************************************************************************/
        /*INSERTION SORT*/
        /**********************************************************************************/
        [TestMethod]
        public void InsertionSort_WhenValuesAreAlreadySorted_ExpectedResult()
        {
            int[] expected = { -5, -2, 1, 2, 3, 4, 5, 11, 20, 80, 100 };
            int[] array = { -5, -2, 1, 2, 3, 4, 5, 11, 20, 80, 100 };

            int[] result = shorting.InsertionSort(array);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void InsertionSort_WhenValuesAreUntidy_ExpectedResult()
        {

            int[] expected = { -5, -2, 1, 2, 3, 4, 5, 11, 20, 80, 100 };
            int[] array = { 80, 11, 3, 2, 1, 5, 20, 100, 4, -5, -2 };

            int[] result = shorting.InsertionSort(array);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        /**********************************************************************************/
        /*REMOVE*/
        /**********************************************************************************/
        [TestMethod]
        public void Remove_WhenThereAre2Values_ExpectedResult()
        {
            int[] expected = { -2 };
            int[] array = { -5, -2 };

            int[] result = shorting.Remove(array, 0);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void Remove_WhenThereAreSeveralValues_ExpectedResult()
        {
            int[] expected = { -2, 5, 8, 100 };
            int[] array = { -5, -2, 5, 8, 100 };

            int[] result = shorting.Remove(array, 0);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        /**********************************************************************************/
        /*MERGE*/
        /**********************************************************************************/
        [TestMethod]
        public void Merge_WhenValuesAreAlreadySorted_ExpectedResult()
        {
            int[] expected = { -5, -2, 1, 2, 3, 4, 5 };
            int[] left = { -5, -2, 1, };
            int[] right = { 2, 3, 4, 5 };

            int[] result = shorting.Merge(left, right);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void Merge_WhenValuesAreUntidy_ExpectedResult()
        {

            int[] expected = { -2, 80 };
            int[] left = { 80 };
            int[] right = { -2 };

            int[] result = shorting.Merge(left, right);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        /**********************************************************************************/
        /*MERGE SORT*/
        /**********************************************************************************/
        [TestMethod]
        public void MergeSort_WhenValuesAreAlreadySorted_ExpectedResult()
        {
            int[] expected = { 1, 2, 3, 4, 5, 11, 20, 80, 100 };
            int[] array = { 1, 2, 3, 4, 5, 11, 20, 80, 100 };

            int[] result = shorting.MergeSort(array);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        [TestMethod]
        public void MergeSort_WhenValuesAreUntidy_ExpectedResult()
        {
            int[] expected = { -5, -2, 1, 2, 3, 4, 5, 11, 20, 80, 100 };
            int[] array = { 80, 11, 3, 2, 1, 5, 20, 100, 4, -5, -2 };
            int[] result = shorting.MergeSort(array);

            for (int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }
        }

        /**********************************************************************************/
        /*QUICK SORT*/
        /**********************************************************************************/
        [TestMethod]
        public void QuickSort_WhenValuesAreAlreadySorted_ExpectedResult()
        {
            int[] expected = { 1, 2, 3, 4, 5, 11, 20, 80, 100 };
            int[] array = { 1, 2, 3, 4, 5, 11, 20, 80, 100 };

            shorting.QuickSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], array[i]);
            }
        }

        [TestMethod]
        public void QuickSort_WhenValuesAreUntidy_ExpectedResult()
        {
            int[] expected = { -5, -2, 1, 2, 3, 4, 5, 11, 20, 80, 100 };
            int[] array = { 80, 11, 3, 2, 1, 5, 20, 100, 4, -5, -2 };

            shorting.QuickSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], array[i]);
            }
        }

        /**********************************************************************************/
        /*SELECTION SORT*/
        /**********************************************************************************/
        [TestMethod]
        public void SelecctionSort_WhenValuesAreAlreadySorted_ExpectedResult()
        {
            int[] expected = { 1, 2, 3, 4, 5, 11, 20, 80, 100 };
            int[] array = { 1, 2, 3, 4, 5, 11, 20, 80, 100 };

            shorting.SelecctionSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], array[i]);
            }
        }

        [TestMethod]
        public void SelecctionSort_WhenValuesAreUntidy_ExpectedResult()
        {
            int[] expected = { -5, -2, 1, 2, 3, 4, 5, 11, 20, 80, 100 };
            int[] array = { 80, 11, 3, 2, 1, 5, 20, 100, 4, -5, -2 };

            shorting.SelecctionSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(expected[i], array[i]);
            }
        }

        /**********************************************************************************/
        /*SWAP*/
        /**********************************************************************************/
        [TestMethod]
        public void Swap_WhenSwapTwoNumbers_ExpectedResult()
        {
            int[] expected = { 2, 100 };
            int[] array = { 100, 2, };
            int i = 0;
            int j = 1;
            SortingAlgorithms.Swap(array, i, j);

            for (int k = 0; k < array.Length; k++)
            {
                Assert.AreEqual(expected[k], array[k]);
            }
        }


    }
}