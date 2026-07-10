

using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

//class clsPerson
//{
//    public string FirstName;
//    public string LastName;

//    public string FullName()
//    {
//        return FirstName + " " + LastName;
//    }
//}

class clsPerson
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public clsPerson(int Id, string Name,int Age)
    {
        this.Id = Id;
        this.Name = Name;
        this.Age = Age;
    }
}


class clsA
{
    public int x1;
    public static int x2;

    public int Method1()
    {
        return x1 + x2;
    }

    public static int Method2()
    {
        return x2;
    }

}

class clsEmployee
{
    private int _ID;
    private string _Name = string.Empty;

    public int ID
    {
        get
        {
            return _ID;
        }

        set
        {
            _ID = value;
        }
    }

    // one of the benefits of using set and get is that u can make the property read-only or write-only by only implementing the get or set method respectively.
    public string Name
    {
        get
        {
            return _Name;
        }

        //set
        //{
        //    _Name = value;
        //}
        // now the Name property is read-only because we have only implemented the get method and not the set method.

        //another benifit of using set and get is that u can add validation logic to the set method to ensure that the value being assigned to the property is valid.
        //for example, we can add validation logic to the set method to ensure that the Name property is not set to an empty string or null.
        //we can also add validation logic to the set method to ensure that the ID property is not set to a negative value.
        //we can also add validation logic to the set method to ensure that the ID property is not set to a value that is already assigned to another employee.
        //example :
        //set 
        //{
        //    if (value < 0)
        //    {
        //        throw new ArgumentException("ID cannot be negative");
        //  
    }

    public string? LastName { get; set; }
    // this is called auto-implemented property, it is a shorthand way of defining a property without having to define a private field to back it up. The compiler automatically creates a private, anonymous backing field that can only be accessed through the property's get and set accessors.
    // from under the hood, the compiler generates a private field to store the value of the property, and it generates the get and set methods to access that field. This is useful when you don't need to add any additional logic to the get or set methods, and you just want to expose a simple property.
}


 static class Settings
{
    public static int DayNumber
    {
        get
        {
            return DateTime.Today.Day;
        }
    }

    public static string DayName
    {
        get
        {
            return DateTime.Today.DayOfWeek.ToString();
        }
    }

   

    public static string ProjectPath { get; set; }
}



class clsCalculator
{
    private int Result { get; set; } = 0;
    private int LastNumber { get; set; } = 0;
    private string LastOperation { get; set; } = string.Empty;

    public int Add(int Number)
    {
        LastNumber = Number;
        LastOperation = "Adding";
        Result = Result + Number;
        return Result;
    }

    public int Subtract(int Number)
    {
        LastNumber = Number;
        LastOperation = "subtracting";
        Result = Result - Number;
        return Result;
    }

    public int Multiply(int Number)
    {
        LastNumber = Number;
        LastOperation = "Multiplying";
        Result = Result * Number;
        return Result;
    }

    public int Divide(int Number)
    {
        LastOperation = "Dividing";

        if (Number == 0)
        {
            LastNumber=Number;
            return Result / 1;
        }
        else 
        {
            LastNumber = Number;
            Result /= Number;
            return Result;
        }



        
    }

    public int Modulus(int Number)
    {
        LastNumber = Number;
        LastOperation = "Moduling";
        Result = Result % Number;
        return Result;
    }

    public int Clear()
    {
        LastOperation = "Clearing";
        LastNumber = 0;
        Result = 0;
        return Result;
    }

    public void PrintResult()
    {
        Console.WriteLine("Result After {0} {1} is : {2}", LastOperation, LastNumber, Result);
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //clsPerson person1 = new clsPerson();
        //person1.FirstName = "ahmad";
        //person1.LastName = "Mallad";
        //Console.WriteLine(person1.FullName());


        //clsPerson person2 = new clsPerson();
        //person2.FirstName = "mo";
        //person2.LastName = "moasfw";
        //Console.WriteLine(person2.FullName());


        clsA objA1 = new clsA();
        clsA objA2 = new clsA();

        objA1.x1 = 10;
        objA2.x1 = 20;

        clsA.x2 = 100;

        Console.WriteLine("objA1.x1 : ={0}", objA1.x1); //10
        Console.WriteLine("objA1.x1 : ={0}", objA2.x1); //20
        Console.WriteLine("objA1.method1 results: ={0}", objA1.Method1()); //110
        Console.WriteLine("objA2.method1 results: ={0}", objA2.Method1()); //120

        Console.WriteLine("static method2 results: ={0}", clsA.Method2()); //100
        Console.WriteLine("static x2: ={0}", clsA.x2); //100

        clsEmployee employee1 = new clsEmployee();

        employee1.ID = 1;
        // employee1.Name = "ahmad";

        Console.WriteLine(employee1.Name);
        Console.WriteLine(employee1.ID);


        Console.WriteLine("Day Number: {0}", Settings.DayNumber);
        Console.WriteLine("Day Name: {0}", Settings.DayName);
        Settings.ProjectPath = @"C:\Users\ahmad\source\repos\REDACTED_PROJECT_NAME";
        Console.WriteLine("Project Path: {0}", Settings.ProjectPath);


        clsCalculator Calculator1 = new clsCalculator();

        Calculator1.Clear();

        Calculator1.Add(10);
        Calculator1.PrintResult();

        Calculator1.Add(100);
        Calculator1.PrintResult();

        Calculator1.Subtract(20);
        Calculator1.PrintResult();

        Calculator1.Divide(0);
        Calculator1.PrintResult();

        Calculator1.Divide(2);
        Calculator1.PrintResult();

        Calculator1.Multiply(3);
        Calculator1.PrintResult();

        Calculator1.Clear();
        Calculator1.PrintResult();

        clsPerson Person1 = new clsPerson(1,"ahmad",40);

        Console.WriteLine("Id : {0}", Person1.Id);
        Console.WriteLine("Name : {0}", Person1.Name);
        Console.WriteLine("Age : {0}", Person1.Age);

       


    }
}