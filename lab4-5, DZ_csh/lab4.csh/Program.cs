using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace lab4.csh
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static List<ParallelSearchRes> ArrayThreadTask(object paramObj)
        {
            ParallelSearchThreadParam param = (ParallelSearchThreadParam)paramObj;
            string wordUpper = param.wordPattern.Trim().ToUpper();
            List<ParallelSearchRes> Result = new List<ParallelSearchRes>();
            foreach (string str in param.tempList)
            {
                int dist = ab5library.EditDistanse.Distance(str.ToUpper(), wordUpper);
                if (dist <= param.maxDist)
                {
                    ParallelSearchRes temp = new ParallelSearchRes() { word = str, dist = dist, ThreadNum = param.ThreadNum };
                    Result.Add(temp);
                }
            }
            return Result;
        }
    }
}
