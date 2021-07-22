using System;

namespace mang2chieu
{
    class MainClass
    {
        public static void Nhap(string [,]a, int n,int m) {
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    Console.Write("a[{0}][{1}] = ", i, j);
                    a[i,j] = Console.ReadLine();
                        }
                Console.Write("\n");
                    }
        }
        public static void Xuat(string[,] a, int n, int m) {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) {
                    Console.WriteLine("a[{0}][{1}] = {2} ", i, j, a[i,j]);
                }
            }
        }
        public static void Main(string[] args)
        {
            int n, m;
            
            Console.WriteLine("N = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("M = ");
            m = int.Parse(Console.ReadLine());
            string[,] a = new string[n, m];
            Nhap(a, n, m);
            Xuat(a, n, m);
        }
    }
}
