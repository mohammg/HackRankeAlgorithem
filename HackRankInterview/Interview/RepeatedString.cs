using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackRankInterview.Interview
{
    public class RepeatedString : ICommand
    {/*
        Lilah has a string,(S) , of lowercase English letters that she repeated infinitely many times.

Given an integer,(n) , find and print the number of letter 'a' in the first (n) letters of Lilah's infinite string.

For example, if the string s='abcac'  and ,n=10 the substring we consider is ,abcacabcac the first 10 characters of her infinite string. There are 4 occurrences of a in the substring.
         */
        public void Excute()
        {
            string s = "a";
            long n = 1000000000000;
            Console.WriteLine(repeatedString(s,n));
        }
         long repeatedString(string s, long n)
        {
            int CountA = 0;
            foreach (char letter in s)
            {
                if (letter=='a')
                {
                    CountA++;
                }
            }
            long repeatstring = (long)(n / s.Length);
            long res = repeatstring * CountA;
            for (int i = 0; i < n%s.Length; i++)
            {
                if (s[i]=='a')
                {
                    res++;
                }
            }
            return res;
        }

        public void ExcuteE()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
    }
}
