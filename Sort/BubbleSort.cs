namespace Sort
{
    /// <summary>
    /// 泡沫排序
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// 一般版（時間複雜度O(n^2))
        /// </summary>
        /// <param name="array">數字陣列</param>
        public static void Sort(int[] array)
        {
            // 比較次數，從陣列最大值開始倒數
            for (int i = array.Length - 1; i > 0; i--)
            {
                // 從陣列最左邊開始比較，不斷比對直到排右邊適當的位置
                for (int j = 0; j < i; j++)
                {
                    // 比較相鄰的兩個元素，前面的元素較大就交換
                    if (array[j] > array[j + 1])
                        Swap(array, j, j + 1);
                }
            }
        }

        /// <summary>
        /// 旗標版（時間複雜度O(n^2) / O(n))
        /// </summary>
        /// <param name="array">數字陣列</param>
        public static void FlagSort(int[] array)
        {
            // 比較次數，從陣列最大值開始倒數
            for (int i = array.Length - 1; i > 0; i--)
            {
                bool isSwapped = false;
                // 從陣列最左邊開始比較，不斷比對直到排右邊適當的位置
                for (int j = 0; j < i; j++)
                {
                    // 比較相鄰的兩個元素，前面的元素較大就交換
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                        isSwapped = true;
                    }
                }    
                // 沒有交換代表已經排序完成，不再處理
                // 有機會是排序好的，達到最佳時間複雜度O(n)
                if (!isSwapped)
                    break;
                
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