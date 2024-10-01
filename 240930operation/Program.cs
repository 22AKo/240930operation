namespace _240930operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                Console.WriteLine("int 1 isnt equal to int 2")
            };
            if (numOne <= intOne)
            {
                Console.WriteLine("num one is less tan or equal to int one")
            };
            if (numOne >= intOne)
            {
                Console.WriteLine("num two is more tan or equal to int two")
            };
            Console.WriteLine("enter to end program");
            string endString = Console.ReadLine();
        }   
    }
}