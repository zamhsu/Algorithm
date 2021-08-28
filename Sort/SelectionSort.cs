using System.Collections.Generic;
using System.Linq;

namespace Sort
{
    /// <summary>
    /// 選擇排序
    /// </summary>
    public class SelectionSort
    {
        /// <summary>
        /// 額外空間版（時間複雜度O(n^2)）
        /// </summary>
        /// <param name="array">數字陣列</param>
        public static void ExtraSpaceSort(int[] array)
        {
            List<int> sorted = new List<int>();
            List<int> unsorted = array.ToList();

            // 未排序陣列的長度為0時即排序完成
            while (unsorted.Count > 0)
            {
                int min = ExtractMin(unsorted);
                sorted.Add(min);
            }

            sorted.ToArray().CopyTo(array, 0);
        }

        /// <summary>
        /// 擷取出未排序陣列中的最小值
        /// </summary>
        /// <param name="unsorted">未排序的陣列</param>
        /// <returns></returns>
        private static int ExtractMin(List<int> unsorted)
        {
            int index = 0;
            int min = unsorted[0];

            // 找出陣列裡的最小值
            for (int i = 0; i < unsorted.Count; i++)
            {
                if (unsorted[i] < min)
                {
                    // 目前最小值比目前走訪到的值還大
                    // 更新最小值與其索引值
                    index = i;
                    min = unsorted[i];
                }
            }

            // 移除最小值和回傳最小值
            unsorted.RemoveAt(index);
            return min;
        }

        /// <summary>
        /// 原地置換版（時間複雜度O(n^2)）
        /// </summary>
        /// <param name="array">數字陣列</param>
        public static void InPlaceSort(int[] array)
        {
            int minIndex = 0;
            // 從已排序的結果遞增，最後一個不處理
            for (int i = 0; i < array.Length - 1; i++)
            {
                // 假設目前的值是最小值
                minIndex = i;
                // 從已排序的結果往後一個遞增
                for (int j = i + 1; j < array.Length; j++)
                {
                    // 目前最小值比目前走訪到的值還大
                    if (array[j] < array[minIndex])
                    {
                        // 更新最小值的索引值
                        minIndex = j;
                    }
                }

                // 如果最小值不是目前陣列走訪的第一個值
                // 代表不是最小值，要交換位置
                if (minIndex != i)
                {
                    Swap(array, minIndex, i);
                }
            }
        }

        /// <summary>
        /// 陣列值交換
        /// </summary>
        /// <param name="array">數字陣列</param>
        /// <param name="indexA">要交換的索引值</param>
        /// <param name="indexB">要被交換的索引值</param>
        private static void Swap(int[] array, int indexA, int indexB)
        {
            int tmp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = tmp;
        }
    }
}