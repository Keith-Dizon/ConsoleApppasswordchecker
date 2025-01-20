using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Password Strength Checker ---");

        // user input pass
        Console.Write("Enter a password: ");
        string password = Console.ReadLine();

        // checking password criteria
        bool hasUpper = false;
        bool hasLower = false;
        bool hasDigit = false;
        bool hasSpecial = false;

        // check character
        foreach (char c in password)
        {
            if (char.IsUpper(c)) hasUpper = true;
            else if (char.IsLower(c)) hasLower = true;
            else if (char.IsDigit(c)) hasDigit = true;
            else hasSpecial = true;
        }

        // password length
        bool hasMinimumLength = password.Length >= 8;

        // password strength
        if (hasMinimumLength && hasUpper && hasLower && hasDigit && hasSpecial)
        {
            Console.WriteLine("Strong Password");
        }
        else
        {
            Console.WriteLine("Weak Password. Here's why:");
            if (!hasMinimumLength)
                Console.WriteLine("- Password must be at least 8 characters long.");
            if (!hasUpper)
                Console.WriteLine("- Password must contain at least one uppercase letter.");
            if (!hasLower)
                Console.WriteLine("- Password must contain at least one lowercase letter.");
            if (!hasDigit)
                Console.WriteLine("- Password must contain at least one digit.");
            if (!hasSpecial)
                Console.WriteLine("- Password must contain at least one special character (e.g., @, #, $, etc.).");
        }
    }
}
