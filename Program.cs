internal class Program
{
    public static void Main()
    {
        string Name = "Hazem Ibrahim Abdel-Hamed Mohamed Aldriny";
        int Section = 3;
        Console.WriteLine($"Name: {Name} >> Section:{Section}");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Insertion Sort Algorithm: Move elements that are greater than key one position ahead");
      
      
        int[] arr = { 15, 10, 25, 20, 30, 40, 35 };

        Console.WriteLine("------------------------------------");
        Console.Write("Orginal array ");
        printArray(arr);

        Console.WriteLine("------------------------------------");
        Console.Write("Sorted array ");
        Insertion_Sort(arr);
        printArray(arr);
        Console.ReadLine();
    }

    static void Insertion_Sort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j -= 1;
            }
            arr[j + 1] = key;
        }
    }


    private static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)

            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}