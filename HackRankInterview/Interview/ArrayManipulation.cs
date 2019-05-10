using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackRankInterview.Interview
{
    class ArrayManipulation : ICommand
    {
        static long arrayManipulation(int n, int[][] queries)
        {
            long[] arr = new long[n+1];
            long maxvalue = long.MinValue;
            
            for (int i = 0; i < queries.Length; i++)
            {
                int a = queries[i][0];
                int b = queries[i][1];
                long k = queries[i][2];
                arr[a] += k;
              if(b+1<=n)  arr[b+1] += (k * -1);



            }
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (sum>maxvalue)
                {
                    maxvalue = sum;
                }
            }
            return maxvalue;
        }
        public void Excute()
        {
            int n = 5;
            int m = 3;
            int[][] q = new int[m][];
            q[0] = new int[] { 1, 2, 100 };
            q[1]=new int[]{ 2,5,100};
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
