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
        CountingValleys,
        SockMerchant,
        RepeatedString,
        JumpingonClouds,
        Array2d,
        LeftRotation,
        MinimumSwaps,
        ArrayManipulation,
        NewYearChaos,
       
    }
    public class Exms
    {
        Dictionary<ExmNum, ICommandTest> lists = new Dictionary<ExmNum, ICommandTest>();
        public Exms()
        {
            //class Must inherit from ICommand interface
            //add class to list To use it
            lists.Add(ExmNum.CountingValleys, new CountingValleys());
            lists.Add(ExmNum.SockMerchant, new SockMerchant());
            lists.Add(ExmNum.RepeatedString, new RepeatedString());
            lists.Add(ExmNum.JumpingonClouds, new JumpingonClouds());
            lists.Add(ExmNum.Array2d, new Array2d());
            lists.Add(ExmNum.LeftRotation, new LeftRotation());
            lists.Add(ExmNum.MinimumSwaps, new MinimumSwaps());
            lists.Add(ExmNum.ArrayManipulation, new ArrayManipulation());
            lists.Add(ExmNum.NewYearChaos, new NewYearChaos());
            

        }
        public void DoIt(ExmNum d, bool withExample = true)
        {
            ICommandTest result = null;
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
    public interface ICommandTest
    {
        //you enter prams in code
        void Excute();
        //you enter prams from console
        void ExcuteE();
    }
}
