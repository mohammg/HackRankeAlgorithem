using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackRankInterview.Interview
{
    class ArrayManipulation : ICommandTest
    {/*
        Starting with a 1-indexed array of zeros and a list of operations,
        
        for each operation add a value to each of the array element between 
        two given indices, inclusive.Once all operations have been performed,
        return the maximum value in your array.

For example, the length of your array of zeros.Your list of queries is as follows:

    10 3
   a b k
    1 5 3
    4 8 7
    6 9 1
Add the values of  between the indices and  inclusive:


index->	 1 2 3  4  5 6 7 8 9 10

   [0,0,0, 0, 0,0,0,0,0, 0]
    [3,3,3, 3, 3,0,0,0,0, 0]
    [3,3,3,10,10,7,7,7,0, 0]
    [3,3,3,10,10,8,8,8,1, 0]
    3       7    -3+1  -7 -1
    Example:
    5 3
1 2 100
2 5 100
3 4 100
index->   1    2   3    4    5
       [   0,   0,   0,   0,   0]
       [ 100, 100,   0,   0,   0]
       [ 100, 200, 100, 100, 100]
       [ 100, 200, 200, 200, 100]
         */
        static long arrayManipulation(int n, int[][] queries)
        {
            long[] arr = new long[n + 1];
            for (int i = 0; i < queries.Length; i++)
            {
                int a = queries[i][0];
                int b = queries[i][1];
                long k = queries[i][2];
                arr[a] += k;
                if (b + 1 <= n) arr[b + 1] += (k * -1);
            }
            long sum=0;
            long maxValue = long.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (sum > maxValue)
                    maxValue = sum;
            }

            return maxValue;
        }
        public void Excute()
        {
            int n = 5;
            int m = 3;
            int[][] q = new int[m][];
            q[0] = new int[] { 1, 2, 100 };
            q[1] = new int[] { 2, 5, 100};
            q[2] = new int[] { 3, 4, 100 };
            long result = arrayManipulation(n, q);
            Console.WriteLine(result);
        }

        public void ExcuteE()
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] queries = new int[m][];
            for (int i = 0; i < m; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            long result = arrayManipulation(n, queries);


        }
    }
}
