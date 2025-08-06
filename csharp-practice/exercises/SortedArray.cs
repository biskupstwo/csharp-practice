namespace csharp_practice.exercises;

public class SortedArray
{
    public static int[] GetIntegers(int size)
    {
        int counter = 0;
        int[] array = new int[size];
        while (counter <= size - 1)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                array[counter] = number;
                counter++;
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        return array;
    }

    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Element {i} contents {array[i]}");
        }
    }
    
    //bubbleSort
    public static int[] SortIntegers(int[] unsortedArray)
    {
        int[] sortedArray = (int[])unsortedArray.Clone();
        int temp;
        for (int i = 0; i < unsortedArray.Length-1; i++)
        {
            for (int j = 0; j < unsortedArray.Length-1-i; j++)
            {
                if (sortedArray[j] < sortedArray[j+1])
                {
                    temp = sortedArray[j];
                    sortedArray[j] = sortedArray[j+1];
                    sortedArray[j+1] = temp;
                }
            }
        }

        return sortedArray;
    }

    public static void Playground()
    {
        int[] testArray = GetIntegers(5);
        PrintArray(testArray);
        int[] sortedArray = SortIntegers(testArray);
        PrintArray(sortedArray);
    }
}