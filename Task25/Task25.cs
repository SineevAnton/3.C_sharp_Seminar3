// Input data: integer numbers A and B
// Write a program which contains a function, returning A to the degree of B. 

Console.Write("Enter number A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Enter number B: ");
int numB = int.Parse(Console.ReadLine());

int getPow(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i ++)
    {
        result = result * a;
    }
    return result;
}

Console.WriteLine($"{numA} to the degree of {numB} = {getPow(numA, numB)}");