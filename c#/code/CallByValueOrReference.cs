using System;

class CallByValueOrReference
{
    static void Main(string[] args)
    {

        int[] arr1 = { 1, 2, 3, 4, 5, 6, };
        int[] arr2 = { 1, 2, 3, 4, 5, 6, };
        int a = 2;
        int b = 3;

        Console.WriteLine("value type:");
        Console.WriteLine($"first:{a} next:{b}");
        TestSimple(ref a, b);
        Console.WriteLine($"first:{a} next:{b} \n");

        Console.WriteLine("Reference type: passed by value(default)");
        Console.WriteLine(arr1[0]);
        FirstDouble(arr1);
        Console.WriteLine($"Outside:{arr1[0]}");

        Console.WriteLine("Reference type: passed by reference");
        Console.WriteLine(arr2[0]);
        SecondDouble(ref arr2);
        Console.WriteLine($"Outside:{arr2[0]}");

        Console.ReadLine();
    }

    static void TestSimple(ref int a, int b)
    {
        Console.WriteLine($"first:{a} next:{b}");
        a++;
        b++;
        Console.WriteLine($"first:{a} next:{b}");
    }

    public static void FirstDouble(int[] array)
    {
        //double each elements value
        for (int i = 0; i < array.Length; i++)
            array[i] *= 2;

        //create new object and assign its reference to array
        array = new int[] { 11, 12, 13 };
        Console.WriteLine($"inside:{array[0]}");
    }
    //signature is the only difference
    public static void SecondDouble(ref int[] array)
    {
        //double each elements value
        for (int i = 0; i < array.Length; i++)
            array[i] *= 2;

        //create new object and assign its reference to array
        array = new int[] { 11, 12, 13 };
        Console.WriteLine($"inside:{array[0]}");
    }
}