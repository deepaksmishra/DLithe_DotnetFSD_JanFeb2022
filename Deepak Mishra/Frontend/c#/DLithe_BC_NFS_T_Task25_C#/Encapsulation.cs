
using System;
using System.Reflection;


public class EncapsulationExm
{


    private String EmpName;
    private int EmpAge;

  
    public String Name
    {

        get
        {
            return EmpName;
        }

        set
        {
            EmpName = value;
        }

    }

    // using accessors to get and 
    // set the value of studentAge
    public int Age
    {

        get
        {
            return EmpAge;
        }

        set
        {
            EmpAge = value;
        }

    }


}

class Details
{
    static public void Main()
    {



        EncapsulationExm Employee = new EncapsulationExm();


        Employee.Name = "Deepak";

        Employee.Age = 23;

        Console.WriteLine("Name: " + Employee.Name);
        Console.WriteLine("Age: " + Employee.Age);

       


      
    }
}
  