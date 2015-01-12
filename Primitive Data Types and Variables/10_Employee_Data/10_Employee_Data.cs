using System;
//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

class Employee_Data
{
    static void Main()
    {
        string FirstName = "Dobromira";
        string LastName = "Boycheva";
        byte Age = 24;
        char Gender = 'f';
        long ID = 9006079765;
        uint Unicode = 27569876;
        Console.WriteLine("First Name: {0}", FirstName);
        Console.WriteLine("Last name: {0}", LastName);
        Console.WriteLine("Age: {0}", Age);
        Console.WriteLine("Gender: {0}", Gender);
        Console.WriteLine("Personal ID: {0}", ID);
        Console.WriteLine("Emplyee ID: {0}", Unicode);
    }
}
