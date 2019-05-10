using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackRankInterview.Interview
{
    class LeftRotation : ICommandTest
    {/*
        A left rotation operation on an array shifts each of the array's 
        elements 1 unit to the left. For example, if 2 left rotations are 
        performed on array [1,2,3,4,5], then the array would become [3,4,5,1,2].

Given an array a of n integers and a number,d , perform d left rotations on the array.
Return the updated array to be printed as a single line of space-separated integers.
*/
       void RoatLeft()
        {
            int d = 2;
            int[] arr = { 1, 2, 3, 4, 5 };
            int n = arr.Length;
            var finalRotationCount = d % n;
            if (finalRotationCount > 0)
            {
                var temp = new int[n];
                for (int i = 0; i < n - finalRotationCount; i++)
                {
                    temp[i] = arr[finalRotationCount + i];
                }

                for (int i = 0; i < finalRotationCount; i++)
                {
                    temp[n - finalRotationCount + i] = arr[i];
                }

                arr = temp;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
        public void Excute()
        {
            RoatLeft();
        }

        public void ExcuteE()
        {
            throw new NotImplementedException();
        }
    }
}
