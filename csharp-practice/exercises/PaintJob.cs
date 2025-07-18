namespace csharp_practice.exercises;

public class PaintJob
{
    public static int GetBucketCount(double width, double height, double areaPerBucket, int extraBuckets)
    {
        if (width <= 0 || height <= 0 || areaPerBucket <= 0 || extraBuckets < 0) return -1;
        double area = width * height;
        int numberOfBuckets = (int) Math.Ceiling(area / areaPerBucket)-extraBuckets;
        
        return numberOfBuckets > 0 ? numberOfBuckets : 0;
    }
    
    public static int GetBucketCount(double width, double height, double areaPerBucket)
    {
        if (width <= 0 || height <= 0 || areaPerBucket <= 0) return -1;
        double area = width * height;
        int numberOfBuckets = (int)Math.Ceiling(area / areaPerBucket);

        return numberOfBuckets;
    }

    public static int GetBucketCount(double area, double areaPerBucket)
    {
        if (area <= 0 || areaPerBucket <= 0) return -1;
        return (int)Math.Ceiling(area / areaPerBucket);
    }

    public static void Playground()
    {
        Console.WriteLine(GetBucketCount(-3.4, 2.1, 1.5, 2));
        Console.WriteLine(GetBucketCount(3.4, 2.1, 1.5, 2));
        Console.WriteLine(GetBucketCount(2.75, 3.25, 2.5, 1));
        
        Console.WriteLine(GetBucketCount(-3.4, 2.1, 1.5));
        Console.WriteLine(GetBucketCount(3.4, 2.1, 1.5));
        Console.WriteLine(GetBucketCount(7.25, 4.3, 2.35));
        
        Console.WriteLine(GetBucketCount(3.4, 1.5));
        Console.WriteLine(GetBucketCount(6.26, 2.2));
        Console.WriteLine(GetBucketCount(3.26, 0.75));
    }
}