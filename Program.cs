// See https://aka.ms/new-console-template for more information
class Program
{
    static int Missing(int[] list, int a, int b)
    {
        int missingCount = 0;
        for (int i = a + 1; i < b; i++)
        {
            if (!HasNumber(list, i))
            {
                missingCount++;
            }
        }

        return missingCount;
    }

    static bool HasNumber(int[] list, int num)
    {
        foreach (int item in list)
        {
            // Console.WriteLine("item: " + item + ", num:" + num + ", return: " + (item == num));
            if (item == num)
                return true;
        }
        return false;
    }

    static void Main(string[] args)
    {
        // Generate list with 10 random numbers
        Random random = new Random();
        int listSize = 10;
        int[] list = new int[listSize];
        int minRange = 1;
        int maxRange = 20;

        for (int i = 0; i < listSize; i++)
        {
            list[i] = random.Next(minRange, maxRange + 1);
        }

        // Display the generated list
        Console.WriteLine("Generated List:");
        foreach (int num in list)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int a = 3;
        int b = 9;

        // Show the solution
        Console.WriteLine("a: " + a);
        Console.WriteLine("a: " + b);

        int missingCount = Missing(list, a, b);
        Console.WriteLine($"There are >> {missingCount} << missing numbers in the list between {a} and {b} ");
    }
}
