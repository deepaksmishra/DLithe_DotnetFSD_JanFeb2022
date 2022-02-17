using System;
public class ArrayExample
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };//Declaration of 1d array

        //traversing array  
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}