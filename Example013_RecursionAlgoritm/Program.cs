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
/* 
//Factorial
//5i = 5*4*3*2*1
//     5*4i
//       4*3i
//         3*2i
//           2*1i
double Factorial(int n)
//int Factorial(int n)
//1i = 1
{
    if (n == 1) return 1;
    else return n*Factorial(n-1);
}
//Console.WriteLine(Factorial(3));
for (int i = 1; i < 40; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/
// Fibonacci
// 1 1 2 3 5 8 13 21 34 ....
// fn = fn-1 + fn-2
// f(1) = 1 
// f(2) = 1
// f(n) = f(n-1) + f(n-2)
double Fibonacci(int n) //int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
    for (int i = 1; i < 50; i++) //for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
    //Console.WriteLine(Fibonacci(i));
}