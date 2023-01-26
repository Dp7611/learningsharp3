namespace learningsharp3;
class Program
{
    
    static void Main(string[] args)
    {
        
            AgeCalculator();
            Console.ReadKey(true);
    }

    static void AgeCalculator ()
    {
        int year = DateTime.Now.Year;
        Console.WriteLine(year);
    }

    static void conditions ()
    {
        //Check if x is larger than y
        int x = 20;
        int y = 20;

        if (x > y)
        {
            Console.WriteLine("x is greater than y");
        }
        else if(y > x)
        {
            Console.WriteLine("y is greater than x");
        }

        else
        {
           Console.WriteLine("x and y are equal"); 
        }
    }

    static void swapNumbers()
    {
        string num1, num2, temp;

        Console.WriteLine("Input the first number: ");
        num1 = Console.ReadLine();
        Console.WriteLine("Input the second number: ");
        num2 = Console.ReadLine();
        temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("After Swapping :");
        Console.WriteLine($"First Number : {num1}");
        Console.WriteLine($"Second Number : {num2}");
        }
}
