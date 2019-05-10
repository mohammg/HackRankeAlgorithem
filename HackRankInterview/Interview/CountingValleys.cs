using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackRankInterview.Interview
{
    public class CountingValleys : ICommandTest
    {/*Gary is an avid hiker. He tracks his hikes meticulously, paying close attention to small details like
topography. During his last hike, he took exactly steps. For every step he took, he noted if it was an uphill
or a downhill step. Gary's hikes start and end at sea level. We define the following terms:
A mountain is a non-empty sequence of consecutive steps above sea level, starting with a step up from
sea level and ending with a step down to sea level.
A valley is a non-empty sequence of consecutive steps below sea level, starting with a step down from
sea level and ending with a step up to sea level.
Given Gary's sequence of up and down steps during his last hike, find and print the number of valleys he
walked through.*/

        /*
         
          
             */
         int countingValleys(int n, string s)
        {

            int altuted = 0;
            int count = 0;
            char[] arraystep = s.ToArray();
            for (int i = 0; i < n; i++)
            {
                if (arraystep[i] == 'U')
                {
                    if (altuted == -1)
                    {
                        count++;
                    }
                    altuted++;
                }
                else
                {
                    altuted--;
                }
            }
            return count;


        }
        public void Excute()
        {
            int n = 12;
            string s = "DDUUDDUDUUUD";
            Console.WriteLine(countingValleys(n,s));
        }

        public void ExcuteE()
        {
            throw new NotImplementedException();
        }
    }
}
