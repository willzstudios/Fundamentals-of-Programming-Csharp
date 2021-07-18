using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        //throw new System.NotImplementedException("Intended exception.");
        start:
            
            Console.WriteLine();
            Console.WriteLine("Table of Contents:" + Environment.NewLine +
                "1: reveal current Date and Time" + Environment.NewLine +
                "2: sqrt of 12345" + Environment.NewLine +
                "3: prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8" + Environment.NewLine +
                "4: prints your age after 10 years" + Environment.NewLine +
                "2.6: reveal your gender" + Environment.NewLine +
                "3.1: Odd or Even?" + Environment.NewLine +
                "3.2: Divisible by both 5 and 7?" + Environment.NewLine +
                "3.3: 3rd digit of a 3 digit integer is 7?" + Environment.NewLine +
                "3.5: Trapezoid area" + Environment.NewLine +
                "3.7: equivalent mass on the moon!" + Environment.NewLine +
                "3.8: (x,y) point within a circle? of R=5, centre (0,0)" + Environment.NewLine+
                "3.10: rearrange 4 digit integer" + Environment.NewLine);
            Console.WriteLine("Enter the corresponding number to access the method from the table above, for example \"3.10\"");
            
            string menuSelection = Console.ReadLine();
            if(menuSelection == "1")
            {
                //write current date and time to console
                DateTime now = DateTime.Now;
                Console.WriteLine(now);
            }
            if(menuSelection == "2")
            {
                //wirte sqrt of 12345 to console
                string squareroot = Math.Sqrt(12345).ToString();
                Console.WriteLine($"squareroot of 12345 is {squareroot}");
            }
            if(menuSelection == "3")
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
            if (menuSelection == "4")
            {
                //Write a program that reads your age from the console and prints your age after 10 years.
                //how to provide input into console?
                Console.WriteLine("Want me to calculate your age + 10? (y/n)");
                if (Console.ReadLine().Equals("y") || Console.ReadLine().Equals("Y"))
                //if (Console.ReadKey().Key == ConsoleKey.Y) //took a while to figure this syntax..
                {
                    AgePlusTen();
                }
                else
                {
                    //do nothing;
                }
                void AgePlusTen()
                {
                    Console.WriteLine("Input your age:");
                    // Create a string variable and get user input from the keyboard and store it in the variable
                    int userAge = Convert.ToInt32(Console.ReadLine());
                    userAge += 10;
                    Console.WriteLine("Your age plus 10 years is " + userAge);
                }
            }
            if(menuSelection == "hidden")
            {
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
                int hexadec = 0x100;
                Console.WriteLine("int hexadec = 0x100; = 256?" + hexadec);
                //256dec in hexadec is? 256 = 16*16 + 0, hexadec = 10*10 = 100

                //2.5: Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).
                char char72 = (char)72;
                Console.WriteLine("char char72 = (char)72; " + char72);
                char hex72 = (char)0x48;
                Console.WriteLine("char hex72 = (char)0x48; " + hex72 + System.Environment.NewLine + "72 = 4*16 + 8 = 4*10 + 8 = 48 in hexadec");
            }
            if(menuSelection == "2.6")
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
            if(menuSelection == "hidden2")
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
                //2.10: Write a program to print a figure in the shape of a heart by the sign "o".

                Console.WriteLine("    o        o    ");
                Console.WriteLine("  o   o    o    o");
                Console.WriteLine("o       o        o");
                Console.WriteLine("o                o    ");
                Console.WriteLine(" o              o    ");
                Console.WriteLine("   o          o    ");
                Console.WriteLine("     o      o    ");
                Console.WriteLine("       o  o    ");
                Console.WriteLine("        o    ");

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
            if (menuSelection == "3.1")
            {
                //3.1: Write an expression that checks whether an integer is odd or even.
                Console.WriteLine("Want to play \"Odd or Even?\" (y/n)");
                if (Console.ReadLine().Equals("y") || Console.ReadLine().Equals("Y"))
                {
                    OddorEven();
                }
                else
                {
                    //do nothing;
                }
                void OddorEven()
                {
                    int int1;
                    Console.WriteLine("please input an integer. We'll tell you if it's odd or even:");
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
            }
            if (menuSelection == "3.2")
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
            }
            if (menuSelection == "3.3")
            {
                //3.3: Write an expression that looks for a given integer if its third digit (right to left) is 7.
                Console.WriteLine();
                Console.WriteLine("Enter a 3 digit integer, we'll tell you if the third digit is 7 or not");
                int int1 = Convert.ToInt32(Console.ReadLine());
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
            if(menuSelection == "3.5")
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
            }
            if (menuSelection == "3.7")
            {
                //3.7: The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
                Console.WriteLine();
                Console.WriteLine("Enter your mass (kg) (just numbers no need to type kg)");
                float aa = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine($"Your weight on the moon would be equivalent to {0.17 * aa}kg on planet Earth");
            }
            if (menuSelection == "3.8")
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
            }
            if(menuSelection == "3.10")
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
                try
                {
                    fourdigit = Convert.ToInt32(digitstring);
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
                finally
                {
                    int sum = 0;
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
                }
                

            }

        #region lastbitofcode
        here:
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Show Menu Again (Y) or QUIT (Q)?");
            string str123 = Convert.ToString(Console.ReadLine());
            if(str123 == "Y" || str123 == "y")
            {
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
