using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsCreateObject
{
  
    public class UserMainCode3
    {
        public int MinimumCost(int input1, int input2, int input3, int[,] input4)
        {
            HashSet<int> islandsWithMultipleConnections = new HashSet<int>();
            HashSet<int> visitedIslands = new HashSet<int>();

            for (int i = 0; i < input2; i++)
            {
                int islandA = input4[i, 0];
                int islandB = input4[i, 1];

                if (visitedIslands.Contains(islandA))
                    islandsWithMultipleConnections.Add(islandA);
                else
                    visitedIslands.Add(islandA);

                if (visitedIslands.Contains(islandB))
                    islandsWithMultipleConnections.Add(islandB);
                else
                    visitedIslands.Add(islandB);
            }

            return islandsWithMultipleConnections.Count * input3;
        }
    }


}

