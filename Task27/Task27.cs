// Task27.
// Write a programm which returns a sum of all digits of an input number

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

int getSummaOfDigits(int number)
{
    int summa = 0;
    while (number != 0)
    {
        summa += number % 10;
        number /= 10;
    }
    return summa;
}

Console.WriteLine($"The sum {num} digits is {getSummaOfDigits(num)}");