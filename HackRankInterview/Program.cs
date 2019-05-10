using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackRankInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Example class
            Exms day = new Exms();
            // chang enum to use another example
            day.DoIt(ExmNum.Exm6, true);

           
            Console.WriteLine("Press Any Key To Exist........");
            Console.ReadKey();
        }
    }
}
