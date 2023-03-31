namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal res = 0;
            TextMenu(res);
            Logic(ref res);
        }
        static void TextMenu(decimal res)
        {

            Console.SetCursorPosition(10, 0);
            string nameApp = "Calculator 2022";
            Console.WriteLine(nameApp);
            Console.SetCursorPosition(10, 1);
            string upperZone = "===============";
            Console.WriteLine(upperZone);
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Enter number [1]:");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("Enter number [2]:");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("Enter operators [+] , [-] , [*] , [/]: ");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("Result is: " + res);



        }
        static decimal Logic(ref decimal res)
        {
            bool isOpen = true;
            do
            {

                decimal num1 = 0;
                decimal num2 = 0;
                string oper;
                
                Console.SetCursorPosition(19, 2);
                num1 = Convert.ToDecimal(Console.ReadLine());
                Console.SetCursorPosition(19, 4);
                num2 = Convert.ToDecimal(Console.ReadLine());
                Console.SetCursorPosition(40, 6);
                oper = Convert.ToString(Console.ReadLine());
                
                switch (oper)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine(num1 + num2);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine(num1 - num2);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine(num1 * num2);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine(num1 / num2);
                        break;
                        
                    default:
                        Console.WriteLine("Its wrong input!");
                        break;

                }
                
                Console.SetCursorPosition(5, 12);
                Console.WriteLine("What your like to continue [Y] - Yes ; [N] - No.");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.Clear();
            return res;
            

        }
    }
}