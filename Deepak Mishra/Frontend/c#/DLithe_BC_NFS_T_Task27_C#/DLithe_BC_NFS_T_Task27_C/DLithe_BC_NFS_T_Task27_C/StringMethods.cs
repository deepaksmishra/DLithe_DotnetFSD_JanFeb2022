using System;
namespace DLithe_BC_NFS_T_Task27_C
{
    internal class StringMethods
    {
    


        class Geeks
        {

            // Main Method
            static void Main(string[] args)
            {

                // Creating an object array
                // Here, It is consist of four 
                // elements only
                object[] array = { "Hello", "Geeks", 12345, 786 };

                // Using Join method
                // Here separator is ', '( comma )
                string s1 = string.Join(", ", array);

                // Finally after joining process gets over
                // Getting the output of value of string s1
                Console.WriteLine("Value of string  s1 is " + s1);
            }
        }
    }
}

