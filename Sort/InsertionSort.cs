using System.Collections.Generic;

namespace Sort
{
    /// <summary>
    /// 選擇排序
    /// </summary>
    public class InsertionSort
    {
        // 主要概念為利用另一個數列來存放已排序部分
        // 逐一取出未排序數列中元素
        // 從已排序數列由後往前找到適當的位置插入

        /// <summary>
        /// 額外空間版
        /// </summary>
        /// <param name="array">數字陣列</param>
        public static void ExtraSpaceSort(int[] array)
        {
            // 待排序陣列從左到右讀取(外層for loop)
            // 額外空間從右到左開始(最大到最小)
            // 額外空間不是第一次執行和額外空間值大於待排序陣列值(內層while loop)
            // 符合while條件，額外空間往左移動
            // while判斷完成，在額外空間插入值

            List<int> sorted = new List<int>();
            // 額外空間的索引
            int sortedIndex = 0;
            // 待排序陣列從左到右讀取
            for (int i = 0; i < array.Length; i++)
            {
                // 儲存額外空間索引，從右到左讀取
                sortedIndex = sorted.Count - 1;
                // 額外空間不是第一次執行和額外空間值大於待排序陣列值
                while (sortedIndex >= 0 && sorted[sortedIndex] > array[i])
                {
                    // 額外空間索引往左移動再次判斷
                    --sortedIndex;
                }

                // 判斷完成，在額外空間插入值
                sorted.Insert(sortedIndex + 1, array[i]);
            }

            sorted.ToArray().CopyTo(array, 0);
        }

        /// <summary>
        /// 原地置換版
        /// </summary>
        /// <param name="array">數字陣列</param>
        public static void InPlaceSort(int[] array)
        {
            // 外層for loop為未排序陣列(整體，從左到右)，從第二個位置開始
            // 用一變數儲存目前待排序的值
            // 內層for loop為已排序的陣列範圍(起始值為外層索引，每次往左移動，從右到左)
            // 內層值大於待排序的值時，內層值往右一格移動，否則代表遇到比較小的值，將待排序的值插入

            int selectedValue, j;
            // 未排序陣列(整體，從左到右)，從第二個位置開始
            for (int i = 1; i < array.Length; i++)
            {
                // 儲存目前待排序的值
                selectedValue = array[i];
                // 已排序的陣列範圍，起始值為外層索引，從右到左
                // 符合已排序值大於目前待排序值時，往左移動
                for (j = i - 1; j >= 0 && array[j] > selectedValue; j--)
                {
                    // 內層值往右一格移動
                    array[j + 1] = array[j];
                }

                // 找到小於的值，將待排序的值插入
                // 會j+1是因為for loop，j已經先-1再判斷條件，已超過小於索引值的位置，要補回來
                array[j + 1] = selectedValue;
            }
        }
    }
}