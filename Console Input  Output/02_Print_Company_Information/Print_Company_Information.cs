using System;
//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

class Print_Company_Information
{
    static void Main()
    {
        Console.Write("Company name: ");
        string Enter1 = Console.ReadLine();
        string CompanyName = string.IsNullOrWhiteSpace(Enter1) ? "No company name" : Enter1;
        Console.Write("Company address:");
        string Enter2 = Console.ReadLine();
        string CompanyAddress = string.IsNullOrWhiteSpace(Enter2) ? "No company address" : Enter2;
        Console.Write("Phone number:");
        string Enter3 = Console.ReadLine();
        string CompanyPhone = string.IsNullOrWhiteSpace(Enter3) ? "No company phone" : Enter3;
        Console.Write("Fax number:");
        string Enter4 = Console.ReadLine();
        string CompanyFax = string.IsNullOrWhiteSpace(Enter4) ? "No company fax" : Enter4;
        Console.Write("Web site:");
        string Enter5 = Console.ReadLine();
        string website = string.IsNullOrWhiteSpace(Enter5) ? "No company website" : Enter5;
        Console.Write("Manager first name:");
        string Enter6 = Console.ReadLine();
        string FirstName = string.IsNullOrWhiteSpace(Enter6) ? "No manager first name" : Enter6;
        Console.Write("Manager last name:");
        string Enter7 = Console.ReadLine();
        string LastName = string.IsNullOrWhiteSpace(Enter7) ? "No manager last name" : Enter7;
        Console.Write("Manager age:");
        string Enter8 = Console.ReadLine();
        string Age = string.IsNullOrWhiteSpace(Enter8) ? "No manager age" : Enter8;
        Console.WriteLine("Manager phone:");
        string Enter9 = Console.ReadLine();
        string Phone = string.IsNullOrWhiteSpace(Enter9) ? "No manager phone" : Enter9;
        Console.WriteLine("{0}\nAdress: {1}\nTel.:{2}\nFax:{3}\nWeb site:{4}\nManager:{5} {6} (age:{7},tel.:{8})", CompanyName, CompanyAddress, CompanyPhone, CompanyFax, website, FirstName, LastName, Age, Phone);
    }
}

