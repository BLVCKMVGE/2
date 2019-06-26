using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class chess_ft
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
        class Field
        {
            int r;
            int c;
            private static StringBuilder str;

            public Field(int r, int c)
            {
                this.r = r;
                this.c = c;
            }

            public String ToString()
            {
                return r + " " + c;
            }
            private void print(List<Field> list)
            {
		        Console.WriteLine(list.Count());
                foreach (Field f in list)
                {
                    Console.WriteLine(f);
                }
            }
            private void solve()
            {
                int n = int.Parse(Console.ReadLine());
                int m = int.Parse(Console.ReadLine());
                myAssert(1 <= n && n <= MAXN);
                myAssert(1 <= m && m <= MAXM);
		        //in.nextLine();
                int[,] b = new int[n,m];

                List<Field> ans1 = new List<Field>();
                List<Field> ans2 = new List<Field>();

                for (int i = 0; i < n; i++)
                {
                    String s = Console.ReadLine();
                    myAssert(s.Count() == m);
                    for (int j = 0; j < m; j++)
                    {
                        char ch = s[j];
                        myAssert(ch == 'B' || ch == 'W');
                        b[i,j] = 0;
                        if (ch == 'W')
                        {
                            b[i,j] = 1;
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        int col1 = (i + j) % 2;
                        if (b[i,j] != col1)
                        {
                            ans1.Add(new Field(i + 1, j + 1));
                        }
                        else
                        {
                            ans2.Add(new Field(i + 1, j + 1));
                        }
                    }
                }
                if (ans1.Count() < ans2.Count())
                {
                    print(ans1);
                }
                else
                {
                    print(ans2);
                }
            }

            public void run()
            {
                try
                {
                    solve();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    Environment.Exit(1);
                }
                finally
                {
                    System.Console.Out.Close();
                }
            }
            static StringBuilder chess_ft()
            {
                try
                {
                    StreamReader reader = new StreamReader("in.txt");
                    StreamWriter writer = new StreamWriter("result.txt");
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.ToString());
                    Environment.Exit(239);
                }
                return str;
            }

            

            public static void Main(String[] args)
            {
                Thread t = new Thread(new ThreadStart(chess_ft));
                t.Start();
            }
        }
    }
}
