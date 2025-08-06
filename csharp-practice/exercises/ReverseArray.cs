namespace csharp_practice.exercises;

public class ReverseArray
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0){
            Console.WriteLine("Array is empty or null.");
            return;
        }
        Console.WriteLine("Array = [" + string.Join(", ", array) + "]");
        int[] reversedArray = new int[array.Length];
        int counter = 0;
        for (int i = array.Length-1; i >= 0; i--)
        {
            reversedArray[counter] = array[i];
            counter++;
        }
        Console.WriteLine("Reversed Array = [" + string.Join(", ", reversedArray) + "]");
    }
}