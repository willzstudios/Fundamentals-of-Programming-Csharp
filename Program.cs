using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //throw new System.NotImplementedException("Intended exception.");
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("MY");
            Console.WriteLine("name");
            Console.WriteLine("is");
            Console.WriteLine("WILLIAM");
            //write current date and time to console
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            //wirte sqrt of 12345 to console
            string squareroot = Math.Sqrt(12345).ToString();
            Console.WriteLine($"squareroot of 12345 is {squareroot}");
            //Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8.
            for (int i = 0; i < 100; i++)
            {
                if (i%2 == 0) //even
                {
                    Console.WriteLine($"{2 + i}"); //2 is 4, 4 is 6
                }
                else //odd
                {
                    Console.WriteLine($"{-2 - i}"); //1 is -3, 3 is -5, 5 is -7
                }
            }
            //Write a program that reads your age from the console and prints your age after 10 years.
            //how to provide input into console?

            Console.WriteLine("Input your age:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string userAge = Console.ReadLine();

            Console.WriteLine("Your age plus 10 years is " + userAge);

            char ch = 'a';
            //looping through figuring out what each (char)# represents
            for (int i = 0; i < 500; i++)
            {
                ch = (char)i;
                Console.WriteLine($"The {i}th char is {ch}");
            }
            //practicing declaring variables: sbyte, byte, short, ushort, int, uint, long, ulong
            //52130, -115, 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789

            //sbyte is an integer with range [-128, 127]
            sbyte essByte = -115;
            //byte is an integer with range [0, 255]
            byte bite = 97;
            //short is an integer with range [-32768, 32769]
            short shoort = -10000;
            ushort youshort = 52130;
            int integer = 970700000;

            float afloat = 1234567000f;
            Console.WriteLine("float can hold 9 digits after decimal? 1234567000f: " + afloat);

            //comparing if two real numbers are accurate within 0.000001
            float a = 1, b = 2;
            bool equal = Math.Abs(a - b) < 0.000001;

            //initialize a variable of type int with value 256 in hexadecimal format (256 is 100 in a numeral system with base 16)
            int hexadec = 0x256;
            Console.WriteLine("int 0x256 = " + hexadec);

            Console.ReadLine();
        }
    }
}
