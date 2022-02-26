using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLithe_BC_NFS_T_Task30
{
    internal class LinkedList
    {
       
public class LinkedListExample
    {
        public static void Main(string[] args)
        {
            // Create a list of strings  
            var names = new LinkedList<string>();
            names.AddLast("Mishra");
            names.AddLast("Deepak");
            names.AddLast("Sam");
            names.AddLast("Raj");
            names.AddFirst("Mac");//added to first index  

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
}
