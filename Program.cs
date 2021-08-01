using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            
            Console.WriteLine(); //"\r\n" does the same thing as System.Environment.NewLine and Console.Writeline();
            Console.WriteLine("~~ TABLE OF CONTENTS: ~~" + "\r\n" + "\r\n" + 
                "1: Reveal current Date and Time" + "\r\n" +
                "2: Find the square root of any number" + "\r\n" +
                "3: Convert integer to Unicode character" + "\r\n" +
                "4: Age calculator" + "\r\n" +
                "5: Draw me a heart! <3" + "\r\n" +
                "3.1: Odd or Even?" + "\r\n" +
                "3.2: Divisible by both 5 and 7?" + "\r\n" +
                "3.3: 3rd digit of a 3 digit integer is 7?" + "\r\n" +
                "3.5: Trapezoid area" + "\r\n" +
                "3.7: equivalent mass on the moon!" + "\r\n" +
                "3.8: (x,y) point within a circle? of R=5, centre (0,0)" + "\r\n" +
                "3.10: rearrange 4-digit integer" + "\r\n" +
                "3.11: base converter \r\n" +
                "3.111: find bit value from any position of a decimal number \r\n" +
                "3.14: Prime number detector \r\n");
            Console.WriteLine(
                "    Enter the corresponding number to access the method from the table above," 
                + "\r\n" +
                "    - For example inputting \"3.10\" will start the \"rearrange 4-digit integer\" method");
            
            string menuSelection = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(menuSelection);
            if (menuSelection == "1")
            {
                Console.WriteLine("The current date and time is : " + DateTime.Now);
            }//current Datetime
            else if (menuSelection == "2")
            {
            sqrtstart:
                Console.WriteLine("Enter a number to square root:");
                string sqrtNumber = Console.ReadLine();
                try
                {
                    double floatNumber = float.Parse(sqrtNumber);
                    double squareroot = Math.Sqrt(floatNumber);
                    Console.WriteLine($"squareroot of {sqrtNumber} is {squareroot}");
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception caught: please enter a number");
                    goto sqrtstart;
                }

            }//sqrt
            else if (menuSelection == "hiddenagain")
            {
                //Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8.
                for (int i = 0; i < 100; i++)
                {
                    if (i % 2 == 0) //even
                    {
                        Console.WriteLine($"{2 + i}"); //2 is 4, 4 is 6
                    }
                    else //odd
                    {
                        Console.WriteLine($"{-2 - i}"); //1 is -3, 3 is -5, 5 is -7
                    }
                }
            }
            else if (menuSelection == "4")
            {
            yearStart:
                Console.WriteLine("Enter the year of your birth");
                try
                {
                    int birthyear = Convert.ToInt32(Console.ReadLine());
                    int currentYear = DateTime.Now.Year;
                    Console.WriteLine($"Your age this year is {currentYear - birthyear}");
                }
                catch (Exception)
                {
                    int randomYear = new Random().Next(1901, 2021);
                    Console.WriteLine($"ERROR: please enter a year, EG: {randomYear}");
                    goto yearStart;
                }

            }//age by year
            else if (menuSelection == "3")
            {
            unicodeStart:
                Console.WriteLine("Enter an integer to reveal its Unicode character!(decimal UTF-16)");
                try
                {
                    int integer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"The Unicode character corresponding to the integer {integer} is {(char)integer}");
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception caught!: please enter an INTEGER");
                    goto unicodeStart;
                }

            }//int to Unicode character
            else if (menuSelection == "anotherhidden")
            {
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
                int hexadec = 0x100;
                Console.WriteLine("int hexadec = 0x100; = 256?" + hexadec);
                //256dec in hexadec is? 256 = 16*16 + 0, hexadec = 10*10 = 100

                //2.5: Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).
                char char72 = (char)72;
                Console.WriteLine("char char72 = (char)72; " + char72);
                char hex72 = (char)0x48;
                Console.WriteLine("char hex72 = (char)0x48; " + hex72 + System.Environment.NewLine + "72 = 4*16 + 8 = 4*10 + 8 = 48 in hexadec");
            }
            else if (menuSelection == "boring")
            {
                //2.6: 6. Declare a variable isMale of type bool and assign a value to it depending on your gender.
                Console.WriteLine("Want me to tell you your gender? (y/n)");
                if (Console.ReadLine().Equals("y") || Console.ReadLine().Equals("Y"))
                {
                    WhatisGender();
                }
                else
                {
                    //do nothing;
                }
                void WhatisGender()
                {
                    bool isMale;
                ministart:
                    Console.WriteLine("Enter your gender (m/f)");
                    string gender = Console.ReadLine();
                    if (gender == "m")
                    {
                        isMale = true;
                        Console.WriteLine("You are male");
                    }
                    else if (gender == "f")
                    {
                        isMale = false;
                        Console.WriteLine("You are female");
                    }
                    else
                    {
                        Console.WriteLine("Error occurred, didn't enter m/f");
                        goto ministart;
                    }
                }
            }
            else if (menuSelection == "hidden2")
            {
                //2.7: Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object.
                string str1 = "Hello";
                string str2 = "World";
                object obj = str1 + str2;
                Console.WriteLine(obj);
                //2.8: Declare two variables of type string and give them values "Hello" and "World". Assign the value obtained by the concatenation of the two variables of type string (do not miss the space in the middle) to a variable of type object. Declare a third variable of type string and initialize it with the value of the variable of type object (you should use type casting).
                obj = str1 + " " + str2;
                string str3 = (string)obj; //type casting here.
                Console.WriteLine(str3);
                //2.9: Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” (without the outer quotes). In one of the variables use quoted string and in the other do not use it.
                str1 = "The \"use\" of quotations causes difficulties.";
                Console.WriteLine(str1);
                Console.WriteLine("\"" + str1 + "\"");
            }
            else if (menuSelection == "5")
            {
                //2.10: Write a program to print a figure in the shape of a heart by the sign "o".
                int randomInt = new Random().Next(1, 99);
                char o = (char)randomInt;
                Console.WriteLine($"    {o}        {o}    ");
                Console.WriteLine($"  {o}   {o}    {o}    {o}");
                Console.WriteLine($"{o}       {o}        {o}");
                Console.WriteLine($"{o}                {o}    ");
                Console.WriteLine($" {o}              {o}    ");
                Console.WriteLine($"   {o}          {o}    ");
                Console.WriteLine($"     {o}      {o}    ");
                Console.WriteLine($"       {o}  {o}    ");
                Console.WriteLine($"        {o}    ");
            } //this is my fav <3!
            else if (menuSelection == "hidden3") 
            {
                //2.11: Write a program that prints on the console isosceles triangle which sides consist of the copyright character "©".
                Console.WriteLine("    ©   ");
                Console.WriteLine("   © ©  ");
                Console.WriteLine("  © © ©  ");

                //2.12: A company dealing with marketing wants to keep a data record of its employees. Each record should have the following characteristic – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types and attribute names.
                //skipping this. seems simple
                //2.13: Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.
                int int11 = 5;
                int int22 = 10;
                Console.WriteLine($"int1 and int2 values are: {int11}, {int22} respectively");
                int int3 = int11;
                int11 = int22;
                int22 = int3;
                Console.WriteLine($" After swapping, int1 and int2 values are: {int11}, {int22} respectively");

            }
            else if (menuSelection == "3.1")
            {
                //3.1: Write an expression that checks whether an integer is odd or even.         
                int int1;
                integerStart:
                Console.WriteLine("please input an integer. We'll tell you if it's odd or even:");
                try
                {
                    int1 = Convert.ToInt32(Console.ReadLine());
                    int1 += 1;
                    if (int1 % 2 == 0)
                    {
                        Console.WriteLine($"Your number was {int1 - 1} and is ODD");
                    }
                    else
                    {
                        Console.WriteLine($"Your number was {int1 - 1} and is EVEN");

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR: please enter an INTEGER, try again");
                    Console.WriteLine("    (Min acceptable value is -2147483647)");
                    Console.WriteLine("    (Max acceptable value is 2147483647)");
                    goto integerStart;
                }
                
            }//odd or even
            else if (menuSelection == "3.2")
            {
                //3.2: Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.
                Console.WriteLine("Want to play Is The Number divisible by both 5 and 7? (y/n)");
                if (Console.ReadLine().Equals("y") || Console.ReadLine().Equals("Y"))
                {
                    FiveandSeven();
                }
                else
                {
                    //do nothing;
                }
                void FiveandSeven()
                {
                    Console.WriteLine("Enter and integer:");
                    int integer = Convert.ToInt32(Console.ReadLine());
                    if (integer % 35 == 0)
                    {
                        Console.WriteLine($"Your number {integer} is divisible by both 5 and 7!");
                    }
                    else
                    {
                        Console.WriteLine($"Your number {integer} is not divisible by both 5 and 7!");
                    }
                }
            }//divisible by 5 and 7?
            else if (menuSelection == "3.3")
            {
                //3.3: Write an expression that looks for a given integer if its third digit (right to left) is 7.
                Console.WriteLine();
                Console.WriteLine("Enter a 3 digit integer, we'll tell you if the third digit is 7 or not");
                thirdDigitSeven:

                try
                {
                    int int1 = Convert.ToInt32(Console.ReadLine());
                    if(int1.ToString().Length != 3)
                    {
                        Console.WriteLine("Please enter only 3 digits!");
                        goto thirdDigitSeven;
                    }
                    int int2;
                    if (int1 % 100 > 0)
                    {
                        int2 = int1 % 100;
                        int2 = int2 % 10;
                        if (int2 == 7)
                        {
                            Console.WriteLine("The third digit is 7!");
                        }
                        else
                        {
                            Console.WriteLine("The third digit is NOT 7!");
                        }
                    }
                }
                catch //huh you don't even have to type catch(exception) here.
                {
                    Console.WriteLine("ERROR: please enter a 3 digit integer");
                    goto thirdDigitSeven;
                }
                
            }//3rd digit 7?
            else if (menuSelection == "3.5")
            {
                //3.5: Write an expression that calculates the area of a trapezoid by given sides a, b and height h.
                Console.WriteLine();
                Console.WriteLine("Find trapezoid area by entering values for sides a, b and height h");
                Console.WriteLine("enter a value for side a");
                float aa = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("enter a value for side b");
                float bb = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("enter a value for height h");
                float hh = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine($"The trapezoid area is equal to {(aa + bb) / 2 * hh} units squared");
            }//trapezoid area
            else if (menuSelection == "3.7")
            {
                //3.7: The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
                Console.WriteLine();
                Console.WriteLine("Enter your mass (kg) (just numbers no need to type kg)");
                float aa = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine($"Your weight on the moon would be equivalent to {0.17 * aa}kg on planet Earth");
            }//moon weight
            else if (menuSelection == "3.8")
            {
                //3.8 Write an expression that checks for a given point {x, y} if it is within the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of the circle and 5 is the radius.
                float x, y;
                Console.WriteLine();
                Console.WriteLine("We're going to figure out if a point x,y is within a circle with centre 0,0 and radius of 5");
                Console.WriteLine("enter a x value for your position (x,y)");
                x = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("enter a y value for your position (x,y)");
                y = Convert.ToSingle(Console.ReadLine());
                //c = sqrt(a^2 + b^2)
                //if c <5, it's within the circle
                x = MathF.Pow(x, 2);
                y = MathF.Pow(y, 2);
                if (Math.Sqrt(x + y) < 5)
                {
                    Console.WriteLine("Hey your point is within the circle!");
                }
                else
                {
                    Console.WriteLine("hey your point is NOT within teh cirlce!");

                }
            }//cartesian point within a circle?
            else if (menuSelection == "3.10")
                //Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:
                /*
                -Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4).
               - Prints on the console the number in reversed order: dcba(in our example 1102).
               - Puts the last digit in the first position: dabc(in our example 1201).
               - Exchanges the second and the third digits: acbd(in our example 2101).
                */
            {
                fourdigit:
                Console.WriteLine("Enter a 4 digit integer");
                string digitstring = Convert.ToString(Console.ReadLine());
                int fourdigit;
                int[] fourdigitArray = new int[4];
                int sum = 0;
                try
                {
                    fourdigit = Convert.ToInt32(digitstring);
                    if (digitstring.Length != 4)
                    {
                        Console.WriteLine("ERROR: please enter exactly 4 digits");
                        goto fourdigit;
                    }
                } 
                catch (FormatException)
                {
                    Console.WriteLine("Exception caught: WRONG FORMATTING, please enter a 4 digit integer");
                    goto fourdigit;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Exception caught: TOO MANY DIGITS, please enter a 4 digit integer");
                    goto fourdigit;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Exception caught: please enter exactly 4 digits");
                    goto fourdigit;
                }
                finally
                {
                    //the goto doesnt seem to skip finally
                    //try catch with finally, has to always go through finally?
                }
                for (int i = 0; i < fourdigitArray.Length; i++)
                {
                    //fourdigitArray[i] = Convert.ToInt32(digitstring[i]); //why is it converting "3" to 51 and "4" to 52 - it's because it's converting from char to int - it's returning the Unicode char integer value. right.
                    //you have to convert char to int, not string to int.

                    //use TYPCASTING from double to int:
                    fourdigitArray[i] = (int)Char.GetNumericValue(digitstring[i]); //wow that's a lot of converting..
                                                                                   //you can also do it like this:
                                                                                   //fourdigitArray[i] = (int)Char.GetNumericValue(digitstring, i);
                    sum = sum + fourdigitArray[i];
                    //Console.WriteLine(sum);
                    //Console.WriteLine(fourdigitArray[i]);
                }
                Console.WriteLine($"The sum of the digits is {sum}");
                Console.WriteLine();
                Console.WriteLine($"printing your digit as dcba from abcd (reverse order): {fourdigitArray[3]}{fourdigitArray[2]}{fourdigitArray[1]}{fourdigitArray[0]}");


            }//rearranging a 4 digit integer
            else if (menuSelection == "3.11")
            {
            baseConverter:
                
                Console.WriteLine("Convert from any base number to any base number!");
                Console.WriteLine("What base would you like to convert from? EG: 10 for decimal base");
                try
                {
                    int fromBase = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What base would you like to convert to? EG: 16 for hexadecimal, 2 for binary");
                    int toBase = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Enter any integer to convert from base {fromBase} to base {toBase}");
                    string number = Console.ReadLine();
                    string result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
                    Console.WriteLine($"{number} from base {fromBase} is equivalent to {result} in base {toBase}");
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("ERROR occurred, try using integer numbers only!");
                    Console.WriteLine();
                    goto baseConverter;
                }
            }//any base to any base converter
            else if (menuSelection == "3.111")
            {
                //We are given a number n and a position p. Write a sequence of operations that prints the value of the bit on the position p in the number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.
  
                Console.WriteLine("Enter an integer and we'll find the p-th value of it's binary form");
                string n = Console.ReadLine();
                    //convert n to binary string
                string binary_n = Convert.ToString(Convert.ToInt32(n, 10), 2);
                Console.WriteLine($"The binary value of {n} is {binary_n}");

                bitP:
                Console.WriteLine("Enter an integer value for p");
                int p = Convert.ToInt32(Console.ReadLine());
                //checking p is within range
                if (p<=binary_n.Length && p > 0)
                {
                    //return p position of binary string n
                    char pBit = binary_n[p - 1]; //p-1 be careful! first index is 0 not 1!

                    Console.WriteLine();
                    Console.Write($"The {p}-th bit of {binary_n} is {pBit}");
                }
                else //go back and ask to re-enter p-value within range.
                {
                    Console.WriteLine("Please enter an integer within the range of the binary number length");
                    goto bitP;
                } 
            }//find p-th bit value of a decimal number
            else if (menuSelection == "3.14")
            {
                primeNumber:
                Console.WriteLine("Enter an integer between 1 and 100 to test if it is a Prime Number!");
                int integer = Convert.ToInt32(Console.ReadLine());
                if(integer>0 && integer < 101)
                {
                    if (integer % 2 == 0 || integer % 3 == 0 || integer % 5 == 0
                    || integer % 7 == 0 || integer % 11 == 0 || integer % 13 == 0
                    || integer % 17 == 0 || integer % 19 == 0 || integer % 23 == 0
                    || integer % 29 == 0 || integer % 31 == 0 || integer % 37 == 0
                    || integer % 41 == 0 || integer % 43 == 0 || integer % 47 == 0)
                    {
                        Console.WriteLine("not a prime number");
                    }
                    else
                    {
                        Console.WriteLine($"Your integer {integer} is a Prime number!");
                    }
                }
                else
                {
                    Console.WriteLine("You failed to enter an integer within the range");
                    goto primeNumber;
                }
                
            }//prime number detector
            else if (menuSelection == "3.15")
            {
                //Write a program that exchanges the values of the bits on positions 
                //3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32 - bit unsigned integer
                //unsigned integer?
                Console.WriteLine("Enter an integer between 0 and 4294967295. We'll swap the 3rd 4th and 5th bit with the 24th 25th and 26th bit");
                string thirtyTwobit = Console.ReadLine();
                
            }
            #region lastbitofcode
            else
            {
                Console.WriteLine("Invalid input, please try again");
            }
        here:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Show Menu Again (Y) or QUIT (Q)?");
            string str123 = Convert.ToString(Console.ReadLine());
            if(str123 == "Y" || str123 == "y")
            {
                Console.Clear();
                goto start;
            }
            else if (str123 == "Q" || str123 == "q")
            {
                //how to quit application?
                Environment.Exit(1);
            }
            else
            {
                goto here;
            }
            //Console.ReadLine();
            #endregion
        }
    }
}
