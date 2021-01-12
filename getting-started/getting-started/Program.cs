using System;
using System.Text;

namespace getting_started
{
    class Program
    {
        static void Main(string[] args)
        {
            // var firstString = "First String";
            // Console.WriteLine(firstString);
            //
            // var firstChar = 'A';
            // Console.WriteLine(firstChar);
            //
            // int firstInt = 5;
            // Console.WriteLine(firstInt);
            //
            // var secondInt = 11;
            // Console.WriteLine(secondInt);
            //
            // int maxIntValue = int.MaxValue;
            // Console.WriteLine();
            //
            // uint positiveInt = 213;
            // Console.WriteLine(positiveInt);
            //
            // uint uintMaxValue = UInt32.MaxValue;
            // Console.WriteLine(uintMaxValue);
            //
            // short firstShortNumber = 23;
            // Console.WriteLine(firstShortNumber);
            //
            // short shortMaxValue = short.MaxValue;
            // Console.WriteLine(shortMaxValue);
            //
            // long longNumber = 31323213213;
            // Console.WriteLine(longNumber);
            //
            // long maxLongValue = long.MaxValue;
            // Console.WriteLine(maxLongValue);




            // Working with strings

            // var simpleString = "  fanTasTic  ";
            // simpleString = simpleString.Trim();
            // Console.WriteLine(simpleString);
            //
            // simpleString = simpleString.ToUpper();
            // Console.WriteLine(simpleString);
            //
            // simpleString = simpleString.ToLower();
            // Console.WriteLine(simpleString);
            //
            // Console.WriteLine(simpleString.Substring(2, 5));
            //
            //
            // var text = "  Text processing in C# is really fuunn!   ";
            // Console.WriteLine(text);
            //
            // text = text.Trim();
            // Console.WriteLine(text);
            //
            // text = text.Substring(24, text.Trim().Length - 25);
            // Console.WriteLine(text);
            //
            // text = text.ToUpper();
            // Console.WriteLine(text);
            //
            // text = text.Trim();
            // Console.WriteLine(text);
            //
            // var anotherText =  "  Text processing in C# is really fuunn!   ";
            // anotherText = anotherText.Trim().Substring(24, anotherText.Trim().Length - 25).ToUpper().Trim();
            // Console.WriteLine(anotherText);




            //Working with the StringBuilder class

            // var someString = new StringBuilder();
            // someString.Append("It was the best of times, it was the worst of times");
            // someString.Append("It was the age of wisdom");
            // someString.Append("It was the age of foolishness");
            // someString.ToString();
            // Console.WriteLine(someString);

            // var someString = new StringBuilder();
            // someString.AppendLine("It was the best of times, it was the worst of times");
            // someString.AppendLine("It was the age of wisdom");
            // someString.AppendLine("It was the age of foolishness");
            // var convertedString = someString.ToString();
            // Console.WriteLine(someString);
            // Console.WriteLine(convertedString);


            // String Formatting

            // var city = "Dhaka";
            // var temperature = 2509.6;
            // var currentDateTime = DateTime.Today;
            // Console.WriteLine("Welcome to {0}. Today is {1:D}. Temperature outside is {2:0,0.00}", city, currentDateTime, temperature);



            // Enumeration
            // Console.WriteLine(weekDays.Monday);
            
            // Working with dates and times
            var birthday = new DateTime(1996, 11, 14);
            Console.WriteLine(birthday);

            var difference = DateTime.Now - birthday;
            Console.WriteLine(difference);
            
            Console.WriteLine(difference.Days);
            Console.WriteLine(difference.Days / 365);

            var newTime = new DateTime(2021, 1, 12, 21, 42, 11);
            Console.WriteLine(newTime);
            
            Console.WriteLine(newTime.AddDays(11));
            Console.WriteLine(newTime.AddDays(-12));




        }

        enum weekDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday
        };
    }
}