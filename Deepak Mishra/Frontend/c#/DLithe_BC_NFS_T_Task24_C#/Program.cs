using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)


        {

            
            Console.WriteLine("Enter Employee Full Name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Employee id");
            string Employeeid = Console.ReadLine();
            Console.WriteLine("Enter Employee Age ");
            string Age = Console.ReadLine();
            Console.WriteLine("Employee Address");
            string address = Console.ReadLine();

            // Create a string variable and get user input from the keyboard and store it in the variable




            // Print the value of the variable (userNames), which will display the input value
            Console.WriteLine("Employee Full name is : " + userName);
            Console.WriteLine("Employee id is " + Employeeid);
            Console.WriteLine("Employee age is " + Age);
            Console.WriteLine("Employee Address is " + address);
            Console.WriteLine("" +
                "" +
                "" +
                "" +
                "");



            //performing arithmatic operation
            Console.WriteLine("BASICS ARTIHMATIC OPERATIONS");
            Console.WriteLine("Enter 1 st value");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter 2nd Value");
            int b = Convert.ToInt16(Console.ReadLine());
           
            int result;
            result = a + b;
            Console.WriteLine("Value is {0}", result);
            result = a - b;
            Console.WriteLine("Value is {0}", result);
            result = a * b;
            Console.WriteLine("Value is {0}", result);
            result = a / b;
            Console.WriteLine("Value is {0}", result);
            result = a % b;
            Console.WriteLine("Value is {0}", result);
            result = a++;
            Console.WriteLine("Value is {0}", result);
            result = a--;
            Console.WriteLine("Value is {0}", result);
            Console.ReadLine();


            //swap of two nos 

            Console.WriteLine("SWAPPING OF TWO NOS ");
            Console.WriteLine("Enter 1 st value for swapping ");
            int j = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter 2nd Value for swapping");
            int k = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Before swap j= " + j + " k= " + k);
            j = j * k; //a=50 (5*10)      
            k = j / k; //b=5 (50/10)      
            j = j / k; //a=10 (50/5)    
            Console.Write("After swap j= " + j + " k= " + k);



            //find the largest nos 

            int num1, num2, num3;
            Console.Write("\n\n");
            Console.Write("Find the largest of between  three numbers:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("Enter 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is greatest \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest no. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest no \n\n");
            else
                Console.Write("The 3rd Number is the greatest no \n\n");
        }


    }
    }


 


