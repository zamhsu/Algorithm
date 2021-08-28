using System;
using System.Text;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 3, 5, 7, 9, 0, 8, 6, 4, 2, 10 };

            // 泡沫排序
            //BubbleSort.Sort(array);
            //BubbleSort.FlagSort(array);

            // 選擇排序
            //SelectionSort.ExtraSpaceSort(array);
            SelectionSort.InPlaceSort(array);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);

                if (i != array.Length - 1)
                    sb.Append(", ");
            }

            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
