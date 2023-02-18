// Задача_№61 Показать двумерный массив размером m×n заполненный вещественными случайными числами

System.Console.WriteLine("Введите желаемое количество строк:");
int N=Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите желаемое колличество столбцов:");
int M=Convert.ToInt32(Console.ReadLine());

double[,] Random2DArray(int N, int M, int min, int max)
{
    double[,] a=new double[N,M];
Random random=new Random();
for(int i=0;i<a.GetLength(0);i++)
for(int j=0;j<a.GetLength(1);j++)
    a[i,j]=random.Next(min,max+1); 
    return a;
}
void Print2DArray(double[,] a)
{

for(int i=0;i<a.GetLength(0);i++)
{
    System.Console.WriteLine();
for(int j=0;j<a.GetLength(1);j++)
 System.Console.Write($"{a[i,j],5}|");
 System.Console.WriteLine();
}
}

double[,] a=Random2DArray(N,M,-100,100);
Print2DArray(a);

