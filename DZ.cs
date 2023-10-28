using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Sem_4
{
    internal class DZ
    {
        public static List<int> FindThreeNumbers(int[] arr, int target, int startIndex)
        {
            Array.Sort(arr);
            
            List<int> result = new List<int>();

            for (int i = startIndex; i < arr.Length - 2; i++)
            {
                int left = i + 1; // берем число из левой части массива, но не первое, к первому будем прибавлять
                int right = arr.Length - 1; // берем число из конца массива

                while (left < right)  // пока не дойдем до середины
                {
                    int sum = arr[i] + arr[left] + arr[right]; // суммируем первое число массива с двумя другими по индексам left и right

                    if (sum == target) // если результат сошелся, записываем числа в массив
                    {
                        result.Add(arr[i]);
                        result.Add(arr[left]);
                        result.Add(arr[right]);
                        break;
                    }
                    else if (sum < target) { left++; } // если сумма элементов меньше, в переменную left берем следующее число
                    else { right--; } // если больше - в переменную right берем предшествующее число
                }

                if (result.Count > 0) { break; }
            }

            return result;
        }
    }
}
