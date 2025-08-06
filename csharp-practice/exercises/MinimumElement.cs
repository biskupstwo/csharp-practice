namespace csharp_practice.exercises;

public class MinimumElement
{
    public static int ReadInteger()
    {
        int number;
        while (true)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int output))
            {
                number = output;
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        return number;
    }

    public static int[] ReadElements(int size)
    {
        int[] array = new int[size];
        int counter = 0;

        while (counter < size)
        {
            array[counter] = ReadInteger();
            counter++;
        }

        return array;
    }

    public static int FindMin(int[] array)
    {
        if (array == null || array.Length == 0) return -1;
        int min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }

        return min;
    }
}