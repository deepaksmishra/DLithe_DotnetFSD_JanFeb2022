using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class main
{
    static void  Main()
    {
        int SNO, MARK1, MARK2, MARK3, AVERAGE , TOTAL;
        string SNAME;
        Console.WriteLine( "ENTER THE STUDENT DETAILS");
        Console.WriteLine(" ENTER THE STUDENT NO");
        SNO = int.Parse(Console.ReadLine());
        Console.WriteLine("ENTER THE STUDENT NAME");
        SNAME = Console.ReadLine();
        Console.WriteLine("ENTER THE MARKS OF 3 SUBJECTS ");
        MARK1 = int.Parse(Console.ReadLine());
        MARK2 = int.Parse(Console.ReadLine());
        MARK2 = int.Parse(Console.ReadLine());
        MARK3 = int.Parse(Console.ReadLine());
        TOTAL = MARK1 + MARK2 + MARK3;
        AVERAGE = TOTAL;
        Console.WriteLine("THE STUDENT DETAILS ARE GIVEN BELOW :");
        Console.WriteLine("THE STUDENT NO IS:" + SNO);
        Console.WriteLine("THE STUUDENT NAME IS: " + SNAME);
        Console.WriteLine(" TOTAL MARKS IS:"+ TOTAL);
        Console.WriteLine("AVEARGE MAARK IS:"+  AVERAGE);
        Console.ReadKey();
    }
}