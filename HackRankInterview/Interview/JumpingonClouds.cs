using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackRankInterview.Interview
{
    public class JumpingonClouds : ICommand
    {

         int jumpingOnClouds(int[] c)
        {
            int count=0;
            int n = c.Length;
            int i = 0;
            while (i<n-1)
            {
if (i+2 <= n - 1&&c[i + 2] == 0 )
                {
                    count++;
                    i += 2;

                }
                else if (c[i + 1] == 0 && i < n - 1)
                {
                    count++;
                    i ++;
                }
            }
            return count;

        }
        public void Excute()
        {
            int[] ar = { 0, 0, 0, 1, 0, 0 };
            Console.WriteLine(jumpingOnClouds(ar));
        }

        public void ExcuteE()
        {
            throw new NotImplementedException();
        }
    }
}
