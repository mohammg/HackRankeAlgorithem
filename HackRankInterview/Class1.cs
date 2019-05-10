using HackRankInterview.Interview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackRankInterview
{
    public enum ExmNum
    {
        Exm0,
        Exm1,
        Exm2,
        Exm3,
        Exm4,
        Exm5,
        Exm6,
        Exm7,
        Exm8,
        Exm9,
        Exm10,
        Exm11,
        Exm12,
        Exm13,
        Exm14,
        Exm15,
        Exm16,
        Exm17,
        Exm18,
        Exm19,
        Exm20,
        Exm21,
        Exm22,
        Exm23,
        Exm24,
        Exm25,
        Exm26,
        Exm27,
        Exm28,
        Exm29,
        Exm30,
    }
    public class Exms
    {
        Dictionary<ExmNum, ICommand> lists = new Dictionary<ExmNum, ICommand>();
        public Exms()
        {
            //class Must inherit from ICommand interface
            //add class to list To use it
            lists.Add(ExmNum.Exm0, new CountingValleys());
            lists.Add(ExmNum.Exm1, new SockMerchant());
            lists.Add(ExmNum.Exm2, new RepeatedString());
            lists.Add(ExmNum.Exm3, new JumpingonClouds());
            lists.Add(ExmNum.Exm4, new Array2d());
            lists.Add(ExmNum.Exm5, new LeftRotation());
            lists.Add(ExmNum.Exm6, new MinimumSwaps());
            lists.Add(ExmNum.Exm7, new ArrayManipulation());
            

        }
        public void DoIt(ExmNum d, bool withExample = true)
        {
            ICommand result = null;
            lists.TryGetValue(d, out result);
            if (result != null)
            {
                if (withExample)
                {
                    result.Excute();
                }
                else
                {
                    result.ExcuteE();
                }

            }
            else
            {
                Console.WriteLine("Not Impelment Exm Code");
            }
        }
    }
    public interface ICommand
    {
        //you enter prams in code
        void Excute();
        //you enter prams from console
        void ExcuteE();
    }
}
