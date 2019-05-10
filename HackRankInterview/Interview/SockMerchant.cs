using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackRankInterview.Interview
{
    public class SockMerchant : ICommandTest
    {/*John works at a clothing store.
        He has a large pile of socks that he must pair by color for sale.
        Given an array of integers representing the color of each sock, 
        determine how many pairs of socks with matching colors there are.

For example, there are  socks with colors . 
There is one pair of color  and one of color . 
There are three odd socks left, one of each color. 
 */
        static int sockMerchant(int n, int[] ar)
        {
            Array.Sort(ar);
            int result = 0;
            for (int i = 0; i < n-1; i++)
            {
                if ( ar[i]==ar[i+1])
                {
                    result++;
                    i++;
                }
            }
            return result;
        }

        public void Excute()
        {
            int n = 9;
            int[] arr = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            Console.WriteLine(sockMerchant(n,arr));
        }

        public void ExcuteE()
        {
            throw new NotImplementedException();
        }
    }
}
