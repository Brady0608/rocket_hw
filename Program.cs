using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Program
    {
        public static void ex5_1()
        {
            Console.WriteLine("Ex5_1");
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"10個數字平均值為{num.Average()}");
            Console.ReadKey();
        }


        public static void ex5_3()
        {
            Console.WriteLine("Ex5_3");
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write($"請輸入第x：");
            int x = Convert.ToInt32(Console.ReadLine());

            var result = Array.IndexOf(num,x);

            string message = result == -1 ? "x不在陣列中" : $"x索引值為{result}";

            Console.WriteLine(message);

            Console.ReadKey();
        }


        public static void ex5_2()
        {
            Console.WriteLine("Ex5_2");
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"最大值為{num.Max()}");
            Console.ReadKey();
        }



        public static void ex5_4()
        {
            Console.WriteLine("Ex5_4");
            int row = 2, col=3;
            int[,] a =  new int[row, col];
            int[,] b = new int[row, col];
            int[,] c = new int[row, col];


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j< col; j++)
                {
                    Console.Write($"請輸入第a[{i}][{j}]：");
                    a[i,j]  = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"請輸入第b[{i}][{j}]：");
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                    c[i,j] = a[i,j] + b[i,j];
                }

            }
            Console.WriteLine($"二維矩陣C：");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }



        public static void ex5_5()
        {
            Console.WriteLine("Ex5_5");

            int row_a = 2, row_b = 3, row_c =2;
            int col_a = 3, col_b = 1, col_c = 1;

            int[,] a = new int[row_a, col_a];
            int[,] b = new int[row_b, col_b];
            int[,] c = new int[row_c, col_c];

            for (int i = 0; i < row_a; i++)
            {
                for (int j = 0; j < col_a; j++)
                {
                    Console.Write($"請輸入第a[{i}][{j}]：");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < row_b; i++)
            {
                for (int j = 0; j < col_b; j++)
                {
                    Console.Write($"請輸入第b[{i}][{j}]：");
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < row_a; ++i) // each row of A
                for (int j = 0; j < col_b; ++j) // each col of B
                    for (int k = 0; k < col_a; ++k)
                        c[i,j] += a[i,k] * b[k,j];

            Console.WriteLine($"二維矩陣C：");
            for (int i = 0; i < row_c; i++)
            {
                for (int j = 0; j < col_c; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }





        public static void hw5_1()
        {
            Console.WriteLine("Hw5_1");
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                num[i] = num[i] > 5 ? num[i]-5 : num[i] + 5;
            }

            Console.WriteLine("Array A: ");

            foreach (int i in num)
            {
               Console.Write(i+" ");
            }
            Console.ReadKey();
        }


        public static void hw5_2()
        {
            Console.WriteLine("Hw5_2");
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine()) + i;
            }

            Console.WriteLine("Array A: ");

            foreach (int i in num)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }


        public static void hw5_3()
        {
            Console.WriteLine("Hw5_3");
            int[] num = new int[10];
            int[] b = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                b[i] = num[i] >= 0 ? 1 : 0;
            }

            Console.WriteLine("Array B: ");

            foreach (int i in b)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }


        public static void hw5_4()
        {
            Console.WriteLine("Hw5_4");
            int row = 3, col = 5;
            int[,] num = new int[row,col];


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"請輸入第num[{i}][{j}]：");
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            
            for (int i = 0; i < 3; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < 5; j++)
                {
                    rowSum += num[i, j];
                }
                Console.WriteLine($"第 {i + 1} 行的和為: {rowSum}");
            }

            for (int j = 0; j < 5; j++)
            {
                int columnSum = 0;
                for (int i = 0; i < 3; i++)
                {
                    columnSum += num[i, j];
                }
                Console.WriteLine($"第 {j + 1} 列的和為: {columnSum}");
            }

            Console.ReadKey();
        }



        public static void hw5_5()
        {
            Console.WriteLine("Hw5_5");
            int row = 3, col = 5;
            int[,] num = new int[row, col];


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"請輸入第num[{i}][{j}]：");
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                int min = num[i,0];
                for (int j = 0; j < 5; j++)
                {
                    if (num[i, j] < min) { min = num[i, j]; }
                }
                Console.WriteLine($"第 {i + 1} 行的最小值為: {min}");
            }

            for (int j = 0; j < 5; j++)
            {
                int min = num[0,j];
                for (int i = 0; i < 3; i++)
                {
                    if (num[i, j] < min) { min = num[i, j]; }   
                }
                Console.WriteLine($"第 {j + 1} 列的最小值為: {min}");
            }

            Console.ReadKey();
        }


        public static void hw5_6()
        {
            Console.WriteLine("Hw5_6");
            int[] a_arr = new int[5];
            int[] b_arr = new int[5];

            while (true)
            {
                Console.Write($"請輸入a1~a5值(ex 1 2 3 4 5)：");
                var a_input = Console.ReadLine();
                a_arr = a_input.Split(' ').Select(int.Parse).ToArray();
                Console.Write($"請輸入b1~b5值(ex 1 2 3 4 5)：");
                var b_input = Console.ReadLine();
                b_arr = b_input.Split(' ').Select(int.Parse).ToArray();


                if (a_arr.Length != 5 && b_arr.Length!=5)
                {
                    Console.WriteLine($"輸入格式錯誤，請重新輸入");
                }
                else { break; }
            }
            for(int i = 0;i < a_arr.Length; i++)
            {
                Console.WriteLine($"a{i+1} + b{i+1} = {a_arr[i] + b_arr[i]}");
            }
            Console.ReadKey();
        }



        public static void hw5_7()
        {
            Console.WriteLine("Hw5_7");
            int[] a_arr = new int[5];
            int[] b_arr = new int[5];

            while (true)
            {
                Console.Write($"請輸入a1~a5值(ex 1 2 3 4 5)：");
                var a_input = Console.ReadLine();
                a_arr = a_input.Split(' ').Select(int.Parse).ToArray();
                Console.Write($"請輸入b1~b5值(ex 1 2 3 4 5)：");
                var b_input = Console.ReadLine();
                b_arr = b_input.Split(' ').Select(int.Parse).ToArray();


                if (a_arr.Length != 5 && b_arr.Length != 5)
                {
                    Console.WriteLine($"輸入格式錯誤，請重新輸入");
                }
                else { break; }
            }
            int min = a_arr.Min() > b_arr.Min() ? b_arr.Min() : a_arr.Min();

            Console.WriteLine($"最小值為{min}");

            Console.ReadKey();
        }

      


        static void Main(string[] args)
        {
            //ex5_1();
            //ex5_2();
            //ex5_3();
            //ex5_4();
            //ex5_5();
            //hw5_1();
            //hw5_2();
            //hw5_3();
            //hw5_4();
            hw5_5();
            //hw5_6();
            //hw5_7();
            Console.ReadKey();

        }
    }
}
