namespace learningsharp3;
class Program
{
    
    static void Main(string[] args)
    {
        
            conditions();
            Console.ReadKey(true);
    }

    static void conditions ()
    {
        //Check if x is larger than y
        int x = 20;
        int y = 2;

        if (x > y)
        {
            Console.WriteLine("x is greater than y");
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
