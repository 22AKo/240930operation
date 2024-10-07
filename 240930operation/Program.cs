namespace _240930operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tempInt = 0;
            double tempNum = 0;
            Console.WriteLine("enter first number");
            double numOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter second number");
            double numTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter first int");
            int intOne = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("enter second int");
            int intTwo = Convert.ToInt32(Console.ReadLine());
            tempNum = intOne + intTwo;
            Console.WriteLine("int 1 + int 2 = " + tempNum);
            tempNum = numOne + numTwo;
            Console.WriteLine("num 1 + num 2 = " + tempNum);
            tempNum = numOne + intOne;
            Console.WriteLine("num 1 + int 1 = " + tempNum);
            tempNum = intOne - intTwo;
            Console.WriteLine("int 1 - int 2 = " + tempNum);
            tempNum = numOne - numTwo;
            Console.WriteLine("num 1 - num 2 = " + tempNum);
            tempNum = numOne - intOne;
            Console.WriteLine("num 1 - int 1 = " + tempNum);
            tempNum = intOne * intTwo;
            Console.WriteLine("int 1 * int 2 = " + tempNum);
            tempNum = numOne * numTwo;
            Console.WriteLine("num 1 * num 2 = " + tempNum);
            tempNum = numOne * intOne;
            Console.WriteLine("num 1 * int 1 = " + tempNum);
            tempNum = intOne / intTwo;
            Console.WriteLine("int 1 / int 2 = " + tempNum);
            tempNum = numOne / numTwo;
            Console.WriteLine("num 1 / num 2 = " + tempNum);
            tempNum = numOne / intOne;
            Console.WriteLine("num 1 / int 1 = " + tempNum);
            tempNum = intOne % intTwo;
            Console.WriteLine("int 1 mod int 2 = " + tempNum);
            tempNum = numOne % numTwo;
            Console.WriteLine("num 1 mod num 2 = " + tempNum);
            tempNum = numOne % intOne;
            Console.WriteLine("num 1 mod int 1 = " + tempNum);
            
            if (numOne == numTwo)
            {
                Console.WriteLine("num 1 is equal to num 2");
            };
            if (intOne != intTwo)
            {
                Console.WriteLine("int 1 isnt equal to int 2");
            };
            if (numOne <= intOne)
            {
                Console.WriteLine("num one is less tan or equal to int one");
            };
            if (numOne >= intOne)
            {
                Console.WriteLine("num two is more tan or equal to int two");
            };
            if (numOne > intOne)
            {
                Console.WriteLine("num one is more than int one");
            };
            if (numOne < intOne)
            {
                Console.WriteLine("num two is less tan int two");
            };
            bool bolOne = int.TryParse(Convert.ToString(numOne), out _);
            bool bolTwo = int.TryParse(Convert.ToString(numTwo), out _);
            if (bolOne)
            {
                Console.WriteLine("num 1 is an int");
            };
            if (!bolTwo)
            {
                Console.WriteLine("num 2 is not an int");
            };
            if (bolOne && bolTwo)
            {
                Console.WriteLine("both num 1 and 2 are ints");
            };
            if (bolOne || bolTwo)
            {
                Console.WriteLine("either num 1 or 2 are ints");
            };
            if (bolOne ^ bolTwo)
            {
                Console.WriteLine("only one of num 1 or 2 are ints");
            };
            if (intOne > intTwo)
            {
                Console.WriteLine("values between int 1 and 2 include:");
                for (int i = intTwo; i < intOne; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (intOne < intTwo)
            {
                Console.WriteLine("values between int 1 and 2 consist of:");
                for (int i = intTwo; i > intOne; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("values between int 1 and 2 consist of:");
                Console.WriteLine(intOne);
            }
            tempNum = intOne % intTwo;
            for (int i = 0; i < tempNum; i++)
            {
                Console.WriteLine(i + ". enter to end program");
            }
           
            string endString = Console.ReadLine();
        }   
    }
}