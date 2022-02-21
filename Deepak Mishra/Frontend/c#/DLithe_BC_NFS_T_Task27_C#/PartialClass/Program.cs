using System;

namespace CompleteInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Record myRecord = new Record("deepak", 15 , "nagpur");
            myRecord.PrintRecord();
            Console.ReadLine();
        }
    }
}