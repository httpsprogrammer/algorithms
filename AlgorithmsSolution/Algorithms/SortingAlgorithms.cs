using System;
using System.Linq;

namespace Algoritmos
{
    public class SortingAlgorithms
    {
        public int[] BubbleSort(int[] array)
        {
            int aux;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        aux = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = aux;
                    }
                }
            }
            return array;
        }

        public int[] CocktailSort(int[] array)
        {
            int aux;
            bool isSwapped = false;
            int start = 0;
            int end = array.Length - 1;
            do
            {
                for (int i = start; i < end; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        aux = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = aux;
                        isSwapped = true;
                    }
                }

                if (!isSwapped)
                    break;

                isSwapped = false;

                for (int i = end; i > start; i--)
                {
                    if (array[i] < array[i - 1])
                    {
                        aux = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = aux;
                        isSwapped = true;
                    }
                }
            } while (isSwapped);
            return array;
        }

        public int[] InsertionSort(int[] array)
        {

            int aux = 0;
            int j = 0;

            for (int i = 1; i < array.Length; i++)
            {
                aux = array[i];
                j = i - 1;

                while (j >= 0 && array[j] > aux)
                {
                    array[j + 1] = array[j];
                    --j;
                }
                array[j + 1] = aux;
            }
            return array;
        }

        public int[] MergeSort(int[] array)
        {
            int middle = array.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[array.Length - middle];

            if (array.Length <= 1)
            {
                return array;
            }
            else
            {
                for (int i = 0; i < left.Length; i++)
                {
                    left[i] = array[i];
                }
                for (int i = 0; i < right.Length; i++)
                {
                    right[i] = array[middle + i];
                }

                left = MergeSort(left);
                right = MergeSort(right);

                return Merge(left, right);
            }
        }

        public int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;

            while (left.Length != 0 || right.Length != 0)
            {
                if (left.Length > 0 && left[i] <= right[j])
                {
                    result[k] = left[i];
                    left = Remove(left, i);
                    ++k;
                }
                else
                {
                    result[k] = right[j];
                    right = Remove(right, j);
                    ++k;
                }
                if (left.Length == 0)
                {
                    while (right.Length != 0)
                    {
                        result[k] = right[j];
                        right = Remove(right, j);
                        ++k;
                    }
                }
                if (right.Length == 0)
                {
                    while (left.Length != 0)
                    {
                        result[k] = left[i];
                        left = Remove(left, i);
                        ++k;
                    }
                }
            }
            return result;
        }

        public int[] Remove(int[] array, int i)
            => array.Where(x => x != array.ElementAt(i)).ToArray();

        public void QuickSort(int[] array)
           => QuickSortFun(array, 0, array.Length - 1);

        private static void QuickSortFun(int[] array, int left, int right)
        {
            int central = (left + right) / 2;
            int pivote = array[central];
            int i = left;
            int j = right;
            int aux;
            do
            {
                while (array[i] < pivote)
                    i++;
                while (array[j] > pivote)
                    j--;

                if (i <= j)
                {
                    aux = array[i];
                    array[i] = array[j];
                    array[j] = aux;
                    i++;
                    j--;
                }

            } while (i <= j);
            if (left <= j)
            {
                QuickSortFun(array, left, j);
            }

            if (i < right)
            {
                QuickSortFun(array, i, right);
            }
        }

        public int[] SelecctionSort(int[] array)
        {
            int id_MinNum = 0;
            int aux = 0;

            for (int i = 0; i < array.Length; i++)
            {
                id_MinNum = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[id_MinNum])
                        id_MinNum = j;
                }
                Swap(array, i, id_MinNum);
            }
            return array;
        }

        public static void Swap(int[] array, int i, int j)
        {
            int aux = array[i];
            array[i] = array[j];
            array[j] = aux;
        }
    }
}
