using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        public static void Main()
        {
            IsNameValid();
            IsEmailValid();
            IsPhoneNumberValid();
            IsDateValid();
        }

        public static void IsNameValid()
        {
            Console.WriteLine("Please enter a valid name:");
            string name = Console.ReadLine();

            Regex nameRegex = new Regex(@"(\b[^a-z0-9_])([a-z]{2,30})\b");

            var result = nameRegex.IsMatch(name) ? "valid!" : "not valid!";
            Console.WriteLine($"The name {name} is {result}");
        }

        public static void IsEmailValid()
        {
            Console.WriteLine("Please enter a valid email:");
            string email = Console.ReadLine();

            Regex emailRegex = new Regex(@"\b[\w]{5,30}@[\w]{5,10}\.[\w]{2,3}");

            var result = emailRegex.IsMatch(email) ? "valid!" : "not valid!";
            Console.WriteLine($"The email {email} is {result}");

        }

        public static void IsPhoneNumberValid()
        {
            Console.WriteLine("Please enter a valid phone number in the format of xxx-xxx-xxxx:");
            string phoneNumber = Console.ReadLine();

            Regex phoneNumberRegex = new Regex(@"\b[0-9]{3}-[0-9]{3}-[0-9]{4}\b");

            var result = phoneNumberRegex.IsMatch(phoneNumber) ? "valid!" : "not valid!";
            Console.WriteLine($"The phone number {phoneNumber} is {result}");
        }

        public static void IsDateValid()
        {
            Console.WriteLine("Please enter a valid date in the format dd/mm/yyyy:");
            string date = Console.ReadLine();

            Regex dateRegex = new Regex(@"\b[0-9]{2}\/[0-9]{2}\/[0-9]{4}\b");

            var result = dateRegex.IsMatch(date) ? "valid!" : "not valid!";
            Console.WriteLine($"The date {date} is {result}");
        }
    }
}
