using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLithe_BC_NFS_T_Task27_C
{
    internal class Nullable
    {
        //nullable compare
        static void Main(string[] args)
        {
            int? i = null;
            int j = 10;


            if (i < j)
                Console.WriteLine("i < j");
            else if (i > 10)
                Console.WriteLine("i > j");
            else if (i == 10)
                Console.WriteLine("i == j");
            else
                Console.WriteLine("Could not compare");
        }
    }
}
