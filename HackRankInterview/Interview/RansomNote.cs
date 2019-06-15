using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackRankInterview.Interview
{/*
    Harold is a kidnapper who wrote a ransom note, but now he is worried it will be traced back to him through his handwriting.
    He found a magazine and wants to know if he can cut out whole words from it and use them to create an untraceable 
    replica of his ransom note.
    The words in his note are case-sensitive and he must use only whole words available in the magazine. 
    He cannot use substrings or concatenation to create the words he needs.
    Given the words in the magazine and the words in the ransom note, 
    print Yes if he can replicate his ransom note exactly using whole words from the magazine; otherwise, print No.

For example, the note is "Attack at dawn". The magazine contains only "attack at dawn". The magazine has all the right words,
but there's a case mismatch. The answer is .No

    give me one grand today night
    give one grand today
out:Yes
two times three is not four
two times two is four
out:No
     
     */
    class RansomNote : ICommandTest
    {
        static void checkMagazine(string[] magazine, string[] note)
        {
            string output = "Yes";
            Dictionary<string, int> dicMagWord = new Dictionary<string, int>();
            foreach (string word in magazine)
            {
                if (dicMagWord.ContainsKey(word))
                {
                    dicMagWord[word] += 1;
                }
                else
                {
                    dicMagWord.Add(word, 1);
                }
            }
            for (int i = 0; i < note.Length; i++)
            {
                if (dicMagWord.ContainsKey(note[i]))
                {
                    dicMagWord[note[i]] -= 1;
                    if (dicMagWord[note[i]]==0)
                    {
                        dicMagWord.Remove(note[i]);
                    }
                }
                else
                {
                    output = "No";
                    break;
                }
            }
            Console.WriteLine(output);

        }
        public void Excute()
        {
            string[] magazine = "give me one grand today night".Split(' ');
            string[] ransom = "give one grand today".Split(' ');
            checkMagazine(magazine, ransom);

        }

        public void ExcuteE()
        {
            throw new NotImplementedException();
        }
    }
}
