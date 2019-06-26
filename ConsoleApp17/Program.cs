using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static int MAXN = 1000;
        private static int MAXM = 1000;

        static private void myAssert(bool e)
        {
            if (!e)
            {
                Console.WriteLine("Assertion failure!!!");
            }
        }
        int r;
        int c;
        private void print(List<Program> list)
        {
            Console.WriteLine(list.Count());
            foreach (Program f in list)
            {
                Console.WriteLine(f);
            }
        }
        public Program(int r, int c)
        {
            this.r = r;
            this.c = c;
        }
        public override String ToString()
        {
            return r + " " + c;
        }
       static private void Print(List<Program> list)
        {
            Console.WriteLine(list.Count());
            foreach (Program f in list)
            {
                Console.WriteLine(f);
            }
        }
        static void Main(string[] args)
        {
            int n;
            while ((!int.TryParse(Console.ReadLine(), out n)) || n < 1)
            {
                Console.WriteLine("Ошибка ввода! Введите целое число n");
            }
            int m;
            while ((!int.TryParse(Console.ReadLine(), out m)) || m > 100)
            {
                Console.WriteLine("Ошибка ввода! Введите целое число m");
            }
            myAssert(1 <= n && n <= MAXN);
            myAssert(1 <= m && m <= MAXM);
            int[,] b = new int[n, m];

            List<Program> ans1 = new List<Program>();
            List<Program> ans2 = new List<Program>();

            for (int i = 0; i < n; i++)
            {
                String s = Console.ReadLine();
                myAssert(s.Count() == m);
                for (int j = 0; j < m; j++)
                {
                    char ch = s[j];
                    myAssert(ch == 'B' || ch == 'W');
                    b[i, j] = 0;
                    if (ch == 'W')
                    {
                        b[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int col1 = (i + j) % 2;
                    if (b[i, j] != col1)
                    {
                        ans1.Add(new Program(i + 1, j + 1));
                    }
                    else
                    {
                        ans2.Add(new Program(i + 1, j + 1));
                    }
                }
            }
            if (ans1.Count() < ans2.Count())
            {
                Print(ans1);
            }
            else
            {
                Print(ans2);
            }
            Console.ReadKey();
        }
    }
}
