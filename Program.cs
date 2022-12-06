using System; 

namespace MyFirstProgram
{
    class Program
    {
        static void Main(String[] args)
        {
            // Creating a Simple Calculator using C# Programming....
            Console.WriteLine("Enter The Firt Number; ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Second Number; ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Chosee from Given MeThamatical Operators(+) (-) (/) (*)");
            String num3 = Console.ReadLine();

            if (num3 == "+")
            {
                int add = (num1 + num2);
                Console.WriteLine("The Sum of The two Numbers is " + add);
            }

            else if (num3 == "-")
            {
                int minus = (num1 - num2);
                Console.WriteLine("The Subtraction of Two Numbers is " + minus);
            }

            else if (num3 == "*")
            {
                int mul = (num1 * num2);
                Console.WriteLine("The Multiplication of Two Numbers is " + mul);
            }

            else if (num3 == "/")
            {
                int div = (num1 / num2);
                Console.WriteLine("The Division of Two Numbers is " + div);
            }

            else
            {
                Console.WriteLine("Something wents Wrong, Please Check your Input and Try again....");
            }


            Console.ReadLine();
        }
    }
}
