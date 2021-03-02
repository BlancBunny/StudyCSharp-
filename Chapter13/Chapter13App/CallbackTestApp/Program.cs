using System;

namespace CallbackTestApp
{
    delegate int Compare(int a, int b);
    class Program
    {
        // a>b 이면 1 / a=b 이면 0 / a<b 이면 -1 리턴
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1;  // a,b 교환 
            else if (a == b) return 0;
            else return -1;
        }

        // a<b 이면 1 / a=b 이면 0 / a>b 이면 -1 리턴
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1;  // a,b 교환 
            else if (a == b) return 0;
            else return -1;
        }

        static void BubbleSort(int[] Dataset, Compare comparer)
        {
            int temp = 0;
            for (int i=0; i<Dataset.Length; i++)
            {
                for (int j = 0; j<Dataset.Length - (i+1); j++)
                {
                    if (comparer(Dataset[j], Dataset[j+1]) == 1)
                    {
                        temp = Dataset[j + 1];
                        Dataset[j + 1] = Dataset[j];
                        Dataset[j] = temp;
                    }
                    // 비교 
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 8, 4, 2, 1, 10 };
            Console.WriteLine("Bubble Sorting");

            BubbleSort(array, new Compare(AscendCompare));
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }

            BubbleSort(array, new Compare(DescendCompare));
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
