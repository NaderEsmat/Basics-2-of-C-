using System.Linq;
namespace Basics_2_of_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1

            // Write a program that takes a number from the user
            // then print yes if that number can be divided by 3 and 4 otherwise print no

            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num % 3 == 0 && num % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");

            #endregion


            #region Question 2

            //Write a program that allows the user to insert an integer
            //then print negative if it is negative number otherwise print positive.

            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else if (num > 0)
            //{
            //    Console.WriteLine("Positive");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Data");
            //}
            #endregion

            #region Question 3

            //  Write a program that takes 3 integers from the user
            // then prints the max element and the min element.

            //int[] set = new int[3];

            //Console.WriteLine("Enter value 1 :");
            //set[0] = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter value 2 :");
            //set[1] = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter value 3 :");
            //set[2] = Convert.ToInt32(Console.ReadLine());

            //int min = set[0];
            //int max = set[0];

            //for (int i = 1; i < set.Length; i++)
            //{
            //    if (set[i] > max)
            //    { max = set[i]; }

            //    else if (set[i] < min) {
            //        min = set[i]; }

            //}

            //Console.WriteLine($"Min = :  {min}");
            //Console.WriteLine($"Max = : {max} ");


            #endregion

            #region Question 4

            // Write a program that allows the user to insert an integer number
            // then check If a number is even or odd.
            //Console.WriteLine("Please enter a value : ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num % 2 == 0) { Console.WriteLine("Even"); }
            //else { Console.WriteLine("Odd"); }

            #endregion

            #region  Question 5 

            //Write a program that takes character from the user
            //then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //Console.WriteLine("Enter a character :");
            // Char letter = Convert.ToChar(Console.ReadLine());

            //if (letter == 'a' || letter == 'o' || letter == 'u' || letter == 'u' || letter == 'e')
            //{
            //    Console.WriteLine("Vowel");

            //}
            //else
            //{
            //    Console.WriteLine("Constant");
            //}






            #endregion

            #region Question 6 

            // Write a program that allows the user to insert an integer
            // then print all numbers between 1 to that number


            //Console.Write("Enter a value : ");
            // int num = Convert.ToInt32(Console.ReadLine());

            // for (int i = 1; i <= num; i++ )
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Question 7

            // Write a program that allows the user to insert an integer then 
            // print a multiplication table up to 12

            //Console.Write("Enter a value : ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    int result = num * +i;
            //    Console.WriteLine(result);


            //}



            #endregion

            #region Question 8 

            // Write a program that allows to user to insert number
            // then print all even numbers between 1 to this number

            //Console.Write("Enter a Value : ");
            //int numb = Convert.ToInt32(Console.ReadLine());

            //for (int i = 2; i < numb; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            #endregion

            #region Question 9 

            // Write a program that takes two integers then prints the power

            //Console.WriteLine("Enter a Value 1st : ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter a Value 2nd : ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //int result = num1;

            //for (int counter = 1; counter < num2; counter++) 
            //{
            //    result *= num1;
            //}
            //Console.WriteLine(result);

            #endregion

            #region Question 10

            //Write a program to enter marks of five subjects and calculate total, average and percentage

            //int num1, num2, num3, num4, num5;

            //Console.WriteLine("Enter value 1 :");
            //num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter value 2 :");
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter value 3 :");
            //num3 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter value 4 :");
            //num4 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter value 5 :");
            //num5 = Convert.ToInt32(Console.ReadLine());

            //int total = num1 + num2 + num3 + num4 + num5;


            //float average = total / 5f;


            //float percentage = (total / 500f) * 100f;


            //Console.WriteLine($"Total : {total}");
            //Console.WriteLine($"Average : {average}");
            //Console.WriteLine($"Percentage: {percentage}%");


            #endregion

            #region Question 11


            //  Write a program to input the month number and print the number of days in that month

            //Console.WriteLine("Enter Month Number");
            //int Month = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Year :");
            //int Year = Convert.ToInt32(Console.ReadLine());

            //int  Days = DateTime.DaysInMonth(Year, Month);
            //Console.WriteLine(Days);
            #endregion

            #region Question 12

            // Write a program to create a Simple Calculator.
            //Console.Write("Enter 1st Value : ");
            //decimal num1 = Convert.ToDecimal(Console.ReadLine());

            //Console.Write("Enter 2nd Value : ");
            //decimal num2 = Convert.ToDecimal(Console.ReadLine());

            //Console.Write("Enter operation (+ , - , / , * ) : ");
            //char operation = Convert.ToChar(Console.ReadLine());    

            //decimal result;
            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine(result);
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine(result);
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine(result);
            //        break;
            //    case '/':
            //        result = num1 / num2;
            //        Console.WriteLine(result);
            //        break;
            //    default:
            //        Console.WriteLine("Wrong operation");
            //        break;
            //}            
            #endregion

            #region Question 13

            // Write a program to allow the user to enter a string and print the REVERSE of it

            //Console.Write("Enter a word : ");
            //string word = Console.ReadLine();

            //string reversed = new string(word.Reverse().ToArray());
            //Console.Write(reversed);

            #endregion

            #region Question 14

            // Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.Write("Enter a number : ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int reversed = 0;

            //while (num != 0)
            //{ 
            //   reversed *= 10;
            //   reversed = reversed + (num % 10);
            //    num = num / 10;
            //}

            //Console.WriteLine(reversed);
            #endregion


            #region Question 15



            #endregion
            //Can't get it 

            #region Question 16

            #endregion
            // Can't get it

            #region Question 17


            //Console.Write("Enter x1: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter y1: ");
            //double y1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter x2: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter y2: ");
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter x3: ");
            //double x3 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter y3: ");
            //double y3 = Convert.ToDouble(Console.ReadLine());


            // double slope1 = (y2-y1) / (x2-x1);
            // double slope2 = (y3-y2) / (x3-x2);

            //if (slope1 == slope2) { Console.WriteLine("They are on the Same Line"); }
            //else { Console.WriteLine("They are NOT on the Same line"); }

            #endregion


            #region Question 18

            //Console.Write("Enter time : ");

            //decimal time = Convert.ToDecimal(Console.ReadLine());

            //if(time >= 2 && time <=3)
            //{
            //    Console.WriteLine("they are considered highly efficient");
            //}
            // else if (time > 3 && time <= 4) 
            //    {
            //        Console.WriteLine("Increase your Speed");
            //    }
            // else if (time > 4 && time <= 5)
            //    {
            //    Console.WriteLine("Training to increase speed");
            //    }
            //else if (time > 5)
            //{
            //    Console.WriteLine("You must leave");
            //}
            #endregion



        }
    }
    
}
