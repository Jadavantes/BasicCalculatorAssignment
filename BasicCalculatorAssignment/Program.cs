namespace BasicCalculatorAssignment
{
    internal class Program
    {
        // The goal of this assignment is to learn how to create and use methods in our code
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an operation: ");

                // Task 1. Read choice input and assing it to new int variable
                int operationChoice = Convert.ToInt32(Console.ReadLine());

                // Task 2. Check if user selected choice 5. If so then exit the loop
                if (operationChoice == 5)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                Console.Write("Enter first number: ");
                // Task 3. Get the first number and assing it to new double variable
                double firstNumber = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                // Task 4. Get the second number and assing it to new double variable
                double secondNumber = Convert.ToDouble(Console.ReadLine());

                // Task 5. Create double variable for default result value and assign it to be 0
                double result = 0;

                // Task 6. Handle choices using switch statement
                // Task 6.1 For each case create new function/method an call it inside the case
                //          - Case 1: Add 
                //          - Case 2: Subtract
                //          - Case 3: Multiply
                //          - Case 4: Divide, Note remeber to handle 0
                // Note: Think what the default choice should be
                // Note: Declare each case function/method outside Main method
                //       There is comment below where you can place your method
                switch (operationChoice)
                {
                case 1:
                    result = Add(firstNumber, secondNumber);
                    break;
                case 2:
                    result = Subtract(firstNumber, secondNumber);
                    break;
                case 3:
                    result = Multiply(firstNumber, secondNumber);
                    break;
                case 4:
                    result = Divide(firstNumber, secondNumber);
                    break;
                }
                // Task 7. Print out the result
                Console.WriteLine(result);
                break;
            }
        }

        // Declare your methods/functions here

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Error: Cannot divide with Zero");
                return 0;
            }
        }
    }
}