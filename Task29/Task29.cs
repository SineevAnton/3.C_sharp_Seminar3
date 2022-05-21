// Task29.
// Write a programm which generates an array with the length, defined by user,
// and fill it with random integer numbers and write it to console

Console.Write("Enter the array size: ");
int arrSize = int.Parse(Console.ReadLine());

int[] generateAndFillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 100); //We can ask user to choose limits for random, but as u said before: "don't complicate the solution"))
    }
    return arr;
}

void printArray(int[] arr)
{
    var st = string.Join(", ", arr);
    Console.WriteLine("Your array is:");
    Console.WriteLine("[{0}]", st);
}

int[] testArray = generateAndFillArray(arrSize);
printArray(testArray);