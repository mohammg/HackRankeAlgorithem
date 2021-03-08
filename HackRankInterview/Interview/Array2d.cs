using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackRankInterview.Interview
{
    public class Array2d : ICommandTest
    {
        FileReadWrite files = new FileReadWrite("Array2d");
        static int hourglassSum(int[][] arr)
        {
           
            int rowCount = arr.Length - 2;

            int maxSum = int.MinValue;
            for (int i = 0; i < rowCount; i++)
            {
                /// Same logic that we are using for rows will be 
                /// applicable for columns too.
                int columnCount = arr[i].Length - 2;
                for (int j = 0; j < columnCount; j++)
                {

                    int sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                            + arr[i + 1][j + 1]
                            + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }
            }
            return maxSum;

        }
        public void Excute()
        {
            int fileCount = files.dirInput.Length;
            for (int f = 0; f < fileCount; f++)
            {
int[][] arr = new int[6][];
                string[] lines = File.ReadAllLines(files.dirInput[f].FullName);
            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(lines[i].Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
                var task = Task.Run(() => hourglassSum(arr));
                if (task.Wait(TimeSpan.FromSeconds(2)))
                {
                    int result = task.Result;
                    int resultFile = int.Parse(File.ReadAllText(files.dirOut[f].FullName));
                    if (result == resultFile)
                        Console.WriteLine($"Test Case {f + 1}: is Done");
                    else
                        Console.WriteLine($"Test Case {f + 1}: is Failed");
                }
                else
                    Console.WriteLine($"Test Case {f + 1}: is Time OUt");


               

                
            }
         

          
//            int[][] arr = new[]
//          {
//    new [] { 1 ,1, 1, 0 ,0 ,0},
//    new [] { 0 ,1 ,0, 0, 0 ,0},
//    new [] { 1 ,1, 1, 0 ,0, 0 },


//     new [] { 0 ,0, 2, 4 ,4 ,0 },
//      new [] { 0, 0, 0, 2 ,0, 0 },
//      new [] { 0, 0, 1, 2 ,4 ,0 }
//};
           
        }

        public void ExcuteE()
        {
            throw new NotImplementedException();
        }
    }


    public interface IReadWrite
    {
        string ReadLine();
        int ReadLineToInt();
        long ReadLineToLong();
        int[] ReadLineToIntArray(string line);
    }
    public class FileReadWrite : IReadWrite
    {
        public FileInfo[] dirInput;
        public FileInfo[] dirOut;

        public FileReadWrite(string folderName)
        {
            dirInput = new System.IO.DirectoryInfo($"Cases\\{folderName}\\input").GetFiles("*.txt",SearchOption.TopDirectoryOnly);
            dirOut = new System.IO.DirectoryInfo($"Cases\\{folderName}\\output").GetFiles("*.txt", SearchOption.TopDirectoryOnly);
        }
        public string ReadLine()
        {
            throw new NotImplementedException();
        }

        public int ReadLineToInt()
        {
            throw new NotImplementedException();
        }

        public int[] ReadLineToIntArray(string line)
        {
            return Array.ConvertAll(line.Split(' '), int.Parse);
        }

        public long ReadLineToLong()
        {
            throw new NotImplementedException();
        }
    }
}
