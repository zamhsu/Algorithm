namespace Sort
{
    public class BubbleSort
    {
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

        private static void Swap(int[] array, int indexA, int indexB)
        {
            int tmp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = tmp;
        }
    }
}