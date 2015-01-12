using System;
//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

class Bank_Account_Data
{
    static void Main()
    {

        string FirstName = "Dobromira";
        string MiddleName = "Nikolaeva";
        string LastName = "Boycheva";
        decimal Balance = 5000.34m;
        string BankName = "FiBank";
        string IBAN = "BG11FIBANK01BGLSF123456";
        long CreditCartNumber1 = 12345678912345678;
        long CreditCartNumber2 = 12345678912345679;
        long CreditCardNumber3 = 12345678912345670;
        Console.WriteLine("First name: {0} \nMiddle name: {1} \nLast name: {2} \nBalance: {3} \nBank name: {4} \nIBAN: {5} \nCredit cart {6} \nCredit cart {7} \nCredit cart {8}", FirstName, MiddleName, LastName, Balance, BankName, IBAN, CreditCartNumber1, CreditCartNumber2, CreditCardNumber3);

    }
}

