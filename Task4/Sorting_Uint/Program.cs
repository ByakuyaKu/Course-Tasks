using System;
using System.Threading;

namespace Sorting_Uint
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 2, 3, 4, 5, 1, 7, 8, 2, 6, 9, 1 };
            int[] array2 = new int[] { 2, 3, 6, 8, 1, 4, 8, 23, 15, 33, 5, 2, 7 };

            SortingEvent.Print(array1);
            SortingEvent.Print(array2);

            SortingEvent sorting = new SortingEvent();

            SortingEvent.OnComplite += SortingEvent.OnCompliteMetod;

            Thread thread1 = new Thread(() => 
            { SortingEvent.Sorting(array1, SortingEvent.Compare); SortingEvent.Print(array1); });

            Thread thread2 = new Thread(() => 
            { Thread.Sleep(TimeSpan.FromSeconds(1)); SortingEvent.Sorting(array2, SortingEvent.Compare); SortingEvent.Print(array2); });

            thread1.Start();
            thread2.Start();
        }

        public class SortingEvent
        {
            static public event Action OnComplite = delegate { };

            static public bool Compare(int num1, int num2) => num1 > num2;

            static public void Sorting(int[] array, Func<int, int, bool> comparer)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    int tmp = array[i];
                    int j = i;
                    while (j > 0 && comparer.Invoke(array[j - 1], tmp))
                    {
                        array[j] = array[j - 1];
                        j--;
                    }
                    array[j] = tmp;
                }
                OnComplite?.Invoke();
            }

            static public void OnCompliteMetod() => Console.WriteLine("Array was sorted:");

            static public void Print(int[] array)
            {
                foreach (var item in array)
                    Console.Write(item + "; ");
                Console.WriteLine();
            }
        }
    }
}
