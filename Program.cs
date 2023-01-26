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
        string name;
        int yearOfBirth;
        string birthdayThisYear;
        int age;
        int currentYear;

        Console.WriteLine("What is your name?");
        name = Console.ReadLine();

        Console.WriteLine("What is your year of birth?");

        yearOfBirth = Convert.ToInt32( Console.ReadLine() );

        Console.WriteLine("Have you had a birthday this year?");

        birthdayThisYear = Console.ReadLine().ToLower();
        currentYear = DateTime.Now.Year;

        if(birthdayThisYear == "yes" || birthdayThisYear == "y")
        {
            age = currentYear - yearOfBirth;
        }
        else
        {
            age = currentYear - yearOfBirth -1;
        }
        Console.WriteLine($"You are {age} years old");

        if(age < 18)
        {
            Console.WriteLine($"You are a junior, {name}");

        } else if(age >= 18 && age < 30)

        {
            Console.WriteLine($"You are a young adult, {name}");

        } else if(age >= 30 && age < 60)
        {
            Console.WriteLine($"You are an adult, {name}");

        }
        else
        {
            Console.WriteLine($"You are a senior, {name}");
        }
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
