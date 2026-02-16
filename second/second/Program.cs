using System;
using System.Collections.Generic;

static string GeneratePassword(int passwordLength)
{
    Random random = new Random();
    List<string> password = new List<string>();

    string numbers = "0123456789";
    string lowercase = "abcdefghijklmnopqrstuvwxyz";
    string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string symbols = "!@#$%^&*-+?";

    // генерируем пароль
    for (int i = 0; i < passwordLength; i++)
    {
        int randomType = random.Next(1, 5);

        if (randomType == 1)
        {
            int index = random.Next(0, numbers.Length);
            password.Add(numbers[index].ToString());
        }
        else if (randomType == 2)
        {
            int index = random.Next(0, lowercase.Length);
            password.Add(lowercase[index].ToString());
        }
        else if(randomType == 3)
        {
            int index = random.Next(0, uppercase.Length);
            password.Add(uppercase[index].ToString());
        } else
        {
            int index = random.Next(0, symbols.Length);
            password.Add(symbols[index].ToString());
        }
    }

    int underscoreIndex = random.Next(0, password.Count);
    password[underscoreIndex] = "_";

    string finalPassword = string.Join("", password);

    return finalPassword;
}

Console.WriteLine("Enter desired password length: ");
int length = int.Parse(Console.ReadLine());
string password = GeneratePassword(length);
Console.WriteLine("Generated password: " + password);
