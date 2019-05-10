using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackRankInterview.Interview
{
    class NewYearChaos : ICommandTest
    {
        /*
         It's New Year's Day and everyone's in line for the Wonderland rollercoaster ride!
         There are a number of people queued up, and each person wears a sticker indicating their initial position in the queue.
         Initial positions increment by 1 from 1 at the front of the line to n at the back.

Any person in the queue can bribe the person directly in front of them to swap positions. 
If two people swap positions, they still wear the same sticker denoting their original places in line. 
One person can bribe at most two others. For example, if n=8 and Person5 bribes Person4, the queue will look like this: 12354678.

Fascinated by this chaotic queue, 
you decide you must know the minimum number of bribes that took place to get the queue into its current state!
             */
         void minimumBribes(int[] arrList)
        {
            
        }

        public void Excute()
        {
            string strLin1 = "2 1 5 3 4";
            string strLin2 = "2 5 1 3 4";
            int[] q1 = Array.ConvertAll(strLin1.Split(' '), qTemp => Convert.ToInt32(qTemp));
            minimumBribes(q1);

            int[] q2 = Array.ConvertAll(strLin2.Split(' '), qTemp => Convert.ToInt32(qTemp));
            minimumBribes(q2);
        }

        public void ExcuteE()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                ;
                minimumBribes(q);
            }
        }
    }
}
