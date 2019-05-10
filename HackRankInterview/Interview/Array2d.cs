using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackRankInterview.Interview
{
    public class Array2d : ICommandTest
    {
        static int hourglassSum(int[][] arr)
        {
           
            int rowCount = arr.Length - 2;

            int maxSum = int.MinValue;
            for (int i = 0; i < rowCount; i++)
            {
                /// Same logic that we are using for rows will be 
                /// applicable for columns too.
                int columnCount = arr[i].Length - 2;
                for (int j = 0; j < columnCount; j++)
                {

                    int sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                            + arr[i + 1][j + 1]
                            + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }
            }
            return maxSum;

        }
        public void Excute()
        {
            int[][] arr = new[]
          {
    new [] { 1 ,1, 1, 0 ,0 ,0},
    new [] { 0 ,1 ,0, 0, 0 ,0},
    new [] { 1 ,1, 1, 0 ,0, 0 },


     new [] { 0 ,0, 2, 4 ,4 ,0 },
      new [] { 0, 0, 0, 2 ,0, 0 },
      new [] { 0, 0, 1, 2 ,4 ,0 }
};
            Console.WriteLine(hourglassSum(arr));
        }

        public void ExcuteE()
        {
            throw new NotImplementedException();
        }
    }
}
