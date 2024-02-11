using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K9.MaxAscend
{
    public class MaxAscend
    {
        public static string Main(string input)
        {
            int[] inputNumbers = Array.ConvertAll(input.Split(' '), int.Parse);
            return string.Join(" ", FindBiggestSortedSublist(inputNumbers));
        }

        public static List<int> FindBiggestSortedSublist(int[] numList)
        {
            List<int> longestAscendingSublist = new List<int>();
            List<int> currentAscendingSublist = new List<int>();

            for (int i = 0; i < numList.Length; i++)
            {
                if (currentAscendingSublist.Count == 0 || numList[i] > currentAscendingSublist[currentAscendingSublist.Count - 1])
                {
                    currentAscendingSublist.Add(numList[i]);
                }
                else
                {
                    if (currentAscendingSublist.Count > longestAscendingSublist.Count)
                    {
                        longestAscendingSublist = new List<int>(currentAscendingSublist);
                    }
                    currentAscendingSublist.Clear();
                    currentAscendingSublist.Add(numList[i]);
                }
            }

            // Check if the last sequence is the longest
            if (currentAscendingSublist.Count > longestAscendingSublist.Count)
            {
                longestAscendingSublist = new List<int>(currentAscendingSublist);
            }

            return longestAscendingSublist;
        }
    }
}
