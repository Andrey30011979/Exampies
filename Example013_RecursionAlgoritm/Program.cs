/*string[,] table = new string[2, 5];
// String.Empty
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]
table [1, 2] = "слово";
for (int rows = 0;rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[ rows, columns]}-");
    }
}
*/
/*
int[,] matrix = new int[3, 4];
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++) //for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)//for (int j = 0; j < 4; j++)
        {
            Console.Write($"{matr[i, j]}");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/
double Factorial(int n)//int Factorial(int n)
{
    if (n == 1) return 1;
    else return n*Factorial(n-1);
}
//Console.WriteLine(Factorial(3));
for (int i = 1; i < 40; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}");
}