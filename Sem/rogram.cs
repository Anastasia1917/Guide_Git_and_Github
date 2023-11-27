// Задача 66:
// int Sum(int M, int N)
// {
//     int sum=0;
//     if (M<N)
//     {
//         for (int i=M; i<=N; i++)
//         {
//             sum+=i;
//         }
//     }
//     else
//     {
//         for(int i=N;i<=M;i++)
//         {
//             sum+=1;
//         }
//     }
//     return sum;
// }
// Console.Write("Введите M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите N: ");
// int N=Convert.ToInt32(Console.ReadLine());
// Console.Write(Sum(M,N));

// Залача 64:
// void Array(int N)
// {
//     if(N<0)
//     {
//         for(int i=N;i!=2;i++)
//         {
//             Console.Write(i+" ");
//         }
//     }
//     else if (N>0)
//     {
//         for(int i=N;i!=0;i--)
//         {
//             Console.Write(i+" ");
//         }
//     }
// }
// Console.Write("Введите N: ");
// int N=Convert.ToInt32(Console.ReadLine());
// Array(N);

// Задача 68
// int Function(int m, int n)
// {
//     if (m==0)
//     {
//         return n+1;
//     }
//     else 
//     {
//         if (m!=0 && n==0)
//         {
//              return Function(m-1, 1);
//         }
//         else
//         {
//             return Function(m-1, Function(m, n-1));
//         }
//     }
// }
// Console.Write("Введите неотрицательное число m: ");
// int m=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите неотрицательное число n: ");
// int n=Convert.ToInt32(Console.ReadLine());
// Console.Write(Function(m,n));