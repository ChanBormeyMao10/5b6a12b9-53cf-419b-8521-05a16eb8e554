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
            List<int> potentialResultListCurrent = new List<int>();
            List<int> potentialResultListBiggest = new List<int>();
            for (int i = 0; i < numList.Count() - 1; i++)
            {
                if (numList[i] < numList[i + 1])
                {
                    potentialResultListCurrent.Add(numList[i]);
                }
                else
                {
                    potentialResultListCurrent.Add(numList[i]);
                    if (potentialResultListCurrent.Count > potentialResultListBiggest.Count)
                    {
                        potentialResultListBiggest = potentialResultListCurrent;
                    }
                    potentialResultListCurrent = new List<int>();
                }
            }
            return potentialResultListBiggest;
        }
    }
}
