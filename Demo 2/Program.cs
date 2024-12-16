namespace Demo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This is The Demo file ; 


            #region String Formating 

            // Note that string as a datatype is immeutable ( Can't change its value after creation );

            // our equation is : X + Y = 12;

            //1.String Concatnation

            // int x = 5; int y = 7;
            //String message = " Equation :" + x + "+" + y + "=" + (x + y);
            //Console.WriteLine(message);

            // The operator + is a function takes string and returns string so it produce many outputs  ... So ->

            // 2.String Format

            //string  message = string.Format(" Equation : {0} + {1} = {2 }", x, y, x + y);
            //Console.WriteLine(message);

            //Confusing .. so the best gor me is .. -->


            //  3.String Interpolution  $ 

            //string message = $"Equation : {x} + {y} = {x + y} ";
            //Console.WriteLine(message);




            #endregion

            #region Conditions & controlling if Else .. Swithes 

            //int monthnumber = Convert.ToInt32(Console.ReadLine());

            //if (monthnumber == 1)

            //{ Console.WriteLine("January"); }

            //else if (monthnumber == 2)
            //{ Console.WriteLine("Febrauary"); }

            //else if (monthnumber == 3) { Console.WriteLine("March"); }

            //else { Console.WriteLine("Invalid Option"); } 

            // if the condition in if is true --> always do what in the curly brackets 
            // if not true   (False) go out to the other if 

            // Switch , Case 
            // Similar to if and else
            // it works with concept Jump Table
            // it didn't check for many cases it only go to the case which is the right one 
            // switch(monthnumber)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break; 

            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;

            //    case 3:
            //        Console.WriteLine("march");
            //        break;
            //    default:
            //        Console.WriteLine("Wrong Data");
            //        break;

            //}

            #endregion

            #region C# Evolution for switches 
            // Matching Pattern 

            // Now wen can search for any data we want with any conditions we want; 
            //object obj = new object();

            //obj = "Ahmed";
            //obj = 5;

            //switch (obj)
            //{
            //    case int x when x < 10:
            //        Console.WriteLine("int 5");
            //        break;

            //    case string y when y.Length > 10:
            //        Console.WriteLine(" No");
            //        break;

            //}



            #endregion

            #region Loops 

            // For Loop 

            /*  for (Statment ; Expression ; Statment)
         {
                Code 
         }
            */

            //Ex :  
            //int x = 5;
            //  for (int c = 1; c<= x; c++)
            //{                                         // print numbers from 1 to 5 
            //    Console.WriteLine(c);
            //}


            // While loop

            // the condition is true in brackests so do the code after 

            //int i = 1;

            //while (i <= 5)
            //{
            //    Console.WriteLine(i);         // Same code but with while
            //    i++;
            //} 

            #endregion



        }
    }
}
