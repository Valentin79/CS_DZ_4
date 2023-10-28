using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Sem_4
{
    internal class DZ
    {
        public static List<int> FindThreeNumbers(int[] arr, int target, int startIndex)
        {
            

            List<int> result = new List<int>();

            for (int i = startIndex; i < arr.Length - 2; i++)
            {
                int left = i + 1;
                int right = arr.Length - 1;

                while (left < right)
                {
                    int sum = arr[i] + arr[left] + arr[right];

                    if (sum == target)
                    {
                        result.Add(arr[i]);
                        result.Add(arr[left]);
                        result.Add(arr[right]);
                        break;
                    }
                    else if (sum < target) { left++; }
                    else { right--; }
                }

                if (result.Count > 0) { break; }
            }

            return result;
        }
    }
}
