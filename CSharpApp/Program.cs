using System;


namespace CSharpApp
{
    class Program
    {
        public static string title = "C# Essential Training";
        public static int whichPart;

        static void Main(string[] args)
        {
            // static string and int
            whichPart = 2;
            var message = string.Format("Welcome to {0} Part {1}!", title, whichPart);
            Console.WriteLine(message);
            Console.WriteLine("Press the enter key to exit.");
            Console.ReadLine();


            // Everything below is copied from the C# Interactive window

            string firstString = "This is my first string variable";
            firstString
                "This is my first string variable"
            5 + 5
                10
            var secondString = "This is my second String";
            secondString
                "This is my second String"



            var firstString = "test 123";
            var firstChar = "A";
            int firstInt = 5;
            var secondInt = 6;
            int bigInt = int.MaxValue;
            uint bitPositiveInt = uint.MaxValue;
            bigInt
                2147483647
            bitPositiveInt
                4294967295
            short smallerNumber = 5;
            short.MaxValue
                32767
            long biggerNumber = 1232345789234234;
            //(1, 6): error CS1519: Invalid token '=' in class, struct, or interface member declaration
            //(1,6) : error CS1525: Invalid expression term '='
            long biggerNumber = 123234234234;
            long.MaxValue
                9223372036854775807
            ulong.MaxValue
                18446744073709551615
            float pie = 3.14;
            //(1,13): error CS0664: Literal of type double cannot be implicitly converted to type 'float'; use an 'F' suffix to create a literal of this type
            float pie = 3.14f;
            var pi = 3.14f;
            double pi2 = 3.14;
            var pi3 = 3.14d;
            bool personalTruth = true;
            var thisIsFalse = false;


            int.Parse("15")
                15
            var test = "12345";
            test.ToUpper() // should be letters
                "12345"
            var test2 = "abcde";
            test2.ToUpper() // read as upper case - ToLower read as lower case
                "ABCDE"
            // No case sensitivity in "string" to take Java into consideration interchangeable
            string foo = "abcde"; // lower case "string"
            String bar = "abcde"; // upper case "String"


            // Strings
            var testString = " abCDefg  ";
            testString.Trim();
            testString.Trim() // Trim all empty spaces
                "abCDefg"
            testString.TrimStart() // Trim empty spaces at start
                "abCDefg  "
            var password = "P@ssw0rd";
            password.ToUpper() // Read all letters as upper case
                "P@SSW0RD"
            password.ToLower() // Read all letters as lower case
                "p@ssw0rd"
            var dickens = "It was the bes times, it was the worst times.";
            dickens.Substring(4, 8) // what is between characters 4 and 8
                "as the b"
            dickens.Length // Number characters
                45
            var challenge = "  Tex processing in C3 is really great!  ";
            challenge.Trim().Substring(24, challenge.Trim().Length - 25).ToUpper().Trim()
                "REALLY GREAT"

            // Concatenation
            var stringOne = "Hello ";
            var stringTwo = "I love you ";
            var stringThree = "Won't you tell me your name?";
            stringOne + stringTwo + stringThree
                "Hello I love you Won't you tell me your name?"


            // String Builder - sb
            // Create instances that is built with seed text
            var sb = new StringBuilder();
            sb.Append("It ws the bes of times, it ws the worst of times");
            sb.Append("It was the age of wisdom");
            sb.Append("it was the age of foolishness");
            sb.ToString()
                "It ws the bes of times, it ws the worst of timesIt was the age of wisdomit was the age of foolishness"
            sb = new StringBuilder("It was the bes of times, ti was the worst of times");
            // ToString = builds string with meaningful text
            sb.ToString()
                "It was the bes of times, ti was the worst of times"
            sb.AppendLine("it ws the age of wisdom");
            sb.AppendLine("it was the age of foolishness");
            sb.ToString()
                "It was the bes of times, ti was the worst of timesit ws the age of wisdom\r\nit was the age of foolishness\r\n"
                    // \r\n = line breaks
            sb = new StringBuilder();
            sb.AppendLine("It was the best of times, it was the worst of times");
            sb.AppendLine("It was the age of wisdom");
            sb.AppendLine("It was the age of foolishness");
            sb.ToString()
                "It was the best of times, it was the worst of times\r\nIt was the age of wisdom\r\nIt was the age of foolishness\r\n"


            // String Formatting
            var city = "Cleveland";
            var temperature = 74.0f;
            var currentDt = DateTime.Now;
            string.Format("Welcome to {0}. The time is {1}. The temperature is {2}.", city, currentDt, temperature)
                "Welcome to Cleveland. The time is 5/17/2018 5:19:34 PM. The temperature is 74."
            string.Format("Welcome to {0}. The time is {1:t}. The temperature is {2}.", city, currentDt, temperature)
                // Format time: t - seconds not used
                "Welcome to Cleveland. The time is 5:19 PM. The temperature is 74."
            string.Format("Welcome to {0}. The time is {1:T}. The temperature is {2}.", city, currentDt, temperature)
                // Format time: T - seconds used
                "Welcome to Cleveland. The time is 5:19:34 PM. The temperature is 74."
            string.Format("Welcome to {0}. The time is {1:T}. The temperature is {2:0.00}.", city, currentDt, temperature)
                // Format temperature: temperature written in decimal format
                "Welcome to Cleveland. The time is 5:19:34 PM. The temperature is 74.00."
            temperature = 1000.25;
                //(1, 15): error CS0664: Literal of type double cannot be implicitly converted to type 'float'; use an 'F' suffix to create a literal of this type
            temperature = 1000.25f;
            string.Format("Welcome to {0}. The time is {1:T}. The temperature is {2:0.00}.", city, currentDt, temperature)
                "Welcome to Cleveland. The time is 5:19:34 PM. The temperature is 1000.25."


            // strings that contain numeric values and turn them back into actual numbers
            // by parsing it into the type you are looking for
            int.Parse("15")
                15

            int.Parse("15,234")
            //Input string was not in a correct format.
            //+ System.Number.StringToNumber(string, System.Globalization.NumberStyles, ref System.Number.NumberBuffer, System.Globalization.NumberFormatInfo, bool)
            //+ System.Number.ParseInt32(string, System.Globalization.NumberStyles, System.Globalization.NumberFormatInfo)

            var test = "15,234";
            int.Parse(test.Replace(",", ""))
                15234


            //TryParse returns a bool
            int result;
            int.TryParse("15,234", out result)
                false
            int.TryParse("15234", out result)
                true  // because comma was removed
            result
                15234


            // Doing basic Math and incrementing
            5 + 5 // add
                10
            6 - 1 // subtract
                5
            7 * 3 // multiple
                21
            21 / 7 // divide
                3
            5 % 2 // modulas = gives the remainder of a division problem
                

            var test = 5;
            test + 1; // increment by 1
            test
                6

            test++; // increment by 1
            test
                7

            test--;  // decrement by 1
            test
                6

            test += 5; // increment by ?
            test
                11

            test -= 5; // decrement by ?
            test
                6

            //// Math Class
            Math.Abs(-5)  // Give absolute value
                5
            Math.Pow(5, 2) // Raise by power of 2
                25
            Math.Round(5.2) // Round - standard
                5
            Math.Floor(5.8) // Round down
                5
            Math.Ceiling(5.2) // Round up
                6
            Math.

            // Constants (const type name = value)

            // Compiler treated as hard coded
            const float pi = 3.14f;
            // Enumeration
            enum weekDays { Monday, Tuesday, Wednesday, Thursday, Friday };
            var someDay = weekDays.Monday;
            enum weekDays { Monday = 1, Tuesday, Wednesday, Thursday, Friday }; // Set Monday starting point 1
            var someDay = weekDays.Wednesday; // Wednesday will be set to 3
                                              // each variable can be set independently


            // DateTime

            // Current
            DateTime.Now
            [5 / 17 / 2018 3:42:20 PM]
            var birthday = new DateTime(1967, 01, 31); // DateTime object with date only

            // Date Spans - result of date arithmatic
            var difference = DateTime.Now - birthday;
            difference
                [18734.15:49:57.9766987]
            difference.Days
                18734
            difference.Days/365 // Determine the amount of years
                51

            var someTime = new DateTime(2018, 5, 17, 3, 52, 32); 
            someTime.AddMinutes(134)
                [5/17/2018 6:06:32 AM]
            var someTime = new DateTime(2018, 5, 17, 15, 52, 32); // list as military time
            someTime.AddMinutes(134)
                [5/17/2018 6:06:32 PM]
            someTime.AddMinutes(-30) // subtracting time
                [5/17/2018 3:22:32 PM]
            someTime.ToFileTime() // Working with Files
                131710603520000000
            someTime.ToLongDateString()
                "Thursday, May 17, 2018"



            





        }
    }
}
