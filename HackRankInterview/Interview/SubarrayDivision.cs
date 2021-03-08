using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackRankInterview.Interview
{
    class SubarrayDivision : ICommandTest
    {
        public int birthday(List<int> s, int d, int m)
        {
            int waycount = 0;
            for (int i = 0; i < s.Count - (m - 1); i++)
                if (s.Skip(i).Take(m).Sum() == d) waycount++;
            return waycount;

        }
        public void Excute()
        {
            List<int> s = "1 1 1 1 1 1".Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = "3 2".Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);
            Console.WriteLine(result);
        }

        public void ExcuteE()
        {
            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);
            Console.WriteLine(result);
        }
    }
}
