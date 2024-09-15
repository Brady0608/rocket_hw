using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Program
    {
        public static void ex3_1()
        {
            Console.WriteLine("Ex3_1");
            int[] num = new int[5];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"五個數字和為{num.Sum()}");
            Console.ReadKey();
        }

        public static void ex3_1_w()
        {
            Console.WriteLine("Ex3_1_while");
            int[] num = new int[5];
            int i = 0;
            while (i < num.Length)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            Console.WriteLine($"五個數字和為{num.Sum()}");
            Console.ReadKey();
        }

        public static void ex3_2()
        {
            Console.WriteLine("Ex3_2");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"{n}個數字和為{num.Sum()}");
            Console.ReadKey();
        }

        public static void ex3_2_w()
        {
            Console.WriteLine("Ex3_2_while");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            int i = 0;
            while (i < num.Length)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            Console.WriteLine($"{n}個數字和為{num.Sum()}");
            Console.ReadKey();
        }

        public static void ex3_3()
        {
            Console.WriteLine("Ex3_3");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"最大值為{num.Max()}");
            Console.ReadKey();
        }

        public static void ex3_3_w()
        {
            Console.WriteLine("Ex3_3_while");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            int i = 0;
            while (i < num.Length)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            Console.WriteLine($"最大值為{num.Max()}");
            Console.ReadKey();
        }

        public static void ex3_4()
        {
            Console.WriteLine("Ex3_4");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (num[i] % 2 == 0) { num[i] = 0; }
            }
            Console.WriteLine($"最大奇數值為：{num.Max()}");
            Console.ReadKey();
        }

        public static void ex3_4_w()
        {
            Console.WriteLine("Ex3_4_while");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine()), i = 0;
            int[] num = new int[n];

            while (i < num.Length)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (num[i] % 2 == 0) { num[i] = 0; }
                i++;
            }
            Console.WriteLine($"最大奇數值為：{num.Max()}");
            Console.ReadKey();
        }

        public static void ex3_5()
        {
            Console.WriteLine("Ex3_5");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine()), sum = 1;

            for (int i = 0; i < n; i++)
            {
                sum *= (i + 1);
            }
            Console.WriteLine($"{n}!值為：{sum}");
            Console.ReadKey();
        }
        public static void ex3_5_w()
        {
            Console.WriteLine("Ex3_5_while");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine()), i = 0, sum = 1;

            while (i < n)
            {
                sum *= (i + 1);
                i++;
            }
            Console.WriteLine($"{n}!值為：{sum}");
            Console.ReadKey();
        }

        public static void ex3_6()
        {
            Console.WriteLine("Ex3_6");
            Console.WriteLine($"開始輸出99乘法表：");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }

        public static void ex3_6_w()
        {
            Console.WriteLine("Ex3_6_while");
            Console.WriteLine($"開始輸出99乘法表：");
            int i = 1, j = 1;
            while (i < 10)
            {
                while (j < 10)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                    j++;
                }
                Console.WriteLine();
                i++; j = 1;

            }
            Console.ReadKey();
        }


        public static void ex3_7()
        {
            Console.WriteLine("Ex3_7");
            Console.WriteLine($"開始輸出99乘法表：");

            for (int i = 1; i < 10; i += 3)
            {

                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{i} * {j} = {i * j}\t\t");
                    Console.Write($"{i + 1} * {j} = {(i + 1) * j}\t\t");
                    Console.WriteLine($"{i + 2} * {j} = {(i + 2) * j}");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }

        public static void ex3_7_w()
        {
            Console.WriteLine("Ex3_7_while");
            Console.WriteLine($"開始輸出99乘法表：");
            int i = 1, j = 1;

            while (i < 10)
            {

                while (j < 10)
                {
                    Console.Write($"{i} * {j} = {i * j}\t\t");
                    Console.Write($"{i + 1} * {j} = {(i + 1) * j}\t\t");
                    Console.WriteLine($"{i + 2} * {j} = {(i + 2) * j}");
                    j++;
                }
                Console.WriteLine();
                i += 3; j = 1;

            }
            Console.ReadKey();
        }



        public static void hw3_1()
        {
            Console.WriteLine("Hw3_1");
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"最小值為{num.Min()}");
            Console.ReadKey();
        }

        public static void hw3_1_w()
        {
            Console.WriteLine("Hw3_1_while");
            int[] num = new int[10];
            int i = 0;
            while (i < num.Length)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            Console.WriteLine($"最小值為{num.Min()}");
            Console.ReadKey();
        }

        public static void hw3_2()
        {
            Console.WriteLine("Hw3_2");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"最小值為{num.Min()}");
            Console.ReadKey();
        }

        public static void hw3_2_w()
        {
            Console.WriteLine("Hw3_2_while");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            int i = 0;
            while (i < num.Length)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            Console.WriteLine($"最小值為{num.Min()}");
            Console.ReadKey();
        }

        public static void hw3_3()
        {
            Console.WriteLine("Hw3_3");
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("大於12數字有：");
            foreach (int i in num)
            {
                if (i > 12)
                {
                    Console.Write(" " + i);
                }
            }
            Console.ReadKey();
        }

        public static void hw3_3_w()
        {
            Console.WriteLine("Hw3_3_while");
            int[] num = new int[10];
            int i = 0;
            while (i < num.Length)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }

            Console.Write("大於12數字有：");
            foreach (int j in num)
            {
                if (j > 12)
                {
                    Console.Write(" " + j);
                }
            }
            Console.ReadKey();
        }

        public static void hw3_4()
        {
            Console.WriteLine("Hw3_4");
            int[] num = new int[10];
            int a;
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 12)
                {
                    num[i] = a;
                }
            }
            Console.Write($"大於12數字之和為： {num.Sum()}");
            Console.ReadKey();
        }

        public static void hw3_4_w()
        {
            Console.WriteLine("Hw3_4_while");
            int[] num = new int[10];
            int a, i = 0;
            while (i < num.Length)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 12)
                {
                    num[i] = a;
                }
                i++;
            }
            Console.Write($"大於12數字之和為： {num.Sum()}");
            Console.ReadKey();
        }

        public static void hw3_5()
        {
            Console.WriteLine("Hw3_5");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (num[i] % 2 == 0) { num[i] = 0; }
            }
            Console.Write($"最大奇數值為：{num.Max()}");
            Console.ReadKey();
        }

        public static void hw3_5_w()
        {
            Console.WriteLine("Hw3_5_while");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine()), i = 0;
            int[] num = new int[n];

            while (i < num.Length)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (num[i] % 2 == 0) { num[i] = 0; }
                i++;
            }
            Console.Write($"最大奇數值為：{num.Max()}");
            Console.ReadKey();
        }

        public static void hw3_6()
        {
            Console.WriteLine("Hw3_6");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine());
            double ans = 0;
            int[] num = new int[n];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (num[i] < 0) { num[i] = 0; }
                ans += Math.Pow(num[i], 2);
            }
            Console.Write($"所有正數平方和為：{ans}");
            Console.ReadKey();
        }

        public static void hw3_6_w()
        {
            Console.WriteLine("Hw3_6_while");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine()), i = 0;
            double ans = 0;
            int[] num = new int[n];

            while (i < num.Length)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (num[i] < 0) { num[i] = 0; }
                ans += Math.Pow(num[i], 2);
                i++;
            }
            Console.Write($"所有正數平方和為：{ans}");
            Console.ReadKey();
        }

        public static void hw3_7()
        {
            Console.WriteLine("Hw3_7");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            }
            Console.Write("所有數字絕對值為：");
            foreach (int j in num)
            {
                Console.Write(" " + j);
            }
            Console.ReadKey();
        }

        public static void hw3_7_w()
        {
            Console.WriteLine("Hw3_7_while");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine()), i = 0;
            int[] num = new int[n];

            while (i < num.Length)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                i++;
            }
            Console.Write("所有數字絕對值為：");
            foreach (int j in num)
            {
                Console.Write(" " + j);
            }
            Console.ReadKey();
        }

        public static void hw3_additional_1()
        {
            Console.WriteLine("Hw3_additional_1");

            int count = 0;
            int[] num = new int[50];
            bool prime = true;

            for (int i = 101; i <= 200; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime == true)
                {
                    num[count] = i;
                    count++;
                }
                else { prime = true; }
            }

            Console.Write($"總共有{count}個質數，為: ");
            foreach (int j in num)
            {
                if (j != 0) { Console.Write(" " + j); }
            }
            Console.ReadKey();
        }

        public static void hw3_additional_1_w()
        {
            Console.WriteLine("Hw3_additional_1_while");

            int count = 0;
            int[] num = new int[50];
            bool prime = true;
            int i = 101;
            while (i <= 200)
            {
                int j = 2;
                while (j < i)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                    j++;
                }
                if (prime == true)
                {
                    num[count] = i;
                    count++;
                }
                else { prime = true; }
                i++;
            }

            Console.Write($"總共有{count}個質數，為: ");
            foreach (int j in num)
            {
                if (j != 0) { Console.Write(" " + j); }
            }
            Console.ReadKey();
        }

        public static void hw3_additional_2()
        {
            Console.WriteLine("Hw3_additional_2");
            Console.Write($"請輸入正整數：");
            int n = Convert.ToInt32(Console.ReadLine()), count = 0;
            int[] num = new int[50];
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    num[count] = i;
                    count++;
                }
            }
            Console.Write($"質因數為： ");
            foreach (int i in num) { if (i != 0) { Console.Write(i + " "); } }
            Console.ReadKey();
        }

        public static void hw3_additional_2_w()
        {
            Console.WriteLine("Hw3_additional_2_while");
            Console.Write($"請輸入正整數：");
            int n = Convert.ToInt32(Console.ReadLine()), count = 0;
            int[] num = new int[50];
            int i = 2;
            while (i <= n)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    num[count] = i;
                    count++;
                }
                i++;
            }
            Console.Write($"質因數為： ");
            foreach (int j in num) { if (j != 0) { Console.Write(j + " "); } }
            Console.ReadKey();
        }

        public static void hw3_additional_3()
        {
            Console.WriteLine("Hw3_additional_3");

            int count = 0;
            int[] num = new int[50];

            for (int i = 100; i <= 300; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    num[count] = i; count++;
                }

            }

            Console.Write($"總共有{count}個數可被3與7整除，為：");
            foreach (int j in num)
            {
                if (j != 0) { Console.Write(j + " "); }
            }
            Console.ReadKey();
        }

        public static void hw3_additional_3_w()
        {
            Console.WriteLine("Hw3_additional_3_while");

            int count = 0, i = 100;
            int[] num = new int[50];


            while (i <= 300)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    num[count] = i; count++;
                }
                i++;
            }

            Console.Write($"總共有{count}個數可被3與7整除，為：");
            foreach (int j in num)
            {
                if (j != 0) { Console.Write(j + " "); }
            }
            Console.ReadKey();
        }

        public static void ex4_1()
        {
            Console.WriteLine("Ex4_1");
            int n;
            while (true)
            {
                Console.Write($"請輸入n：");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0) { break; }
                Console.WriteLine($"輸入數字為{n}");
            }
            Console.WriteLine($"輸入數字為{n}，程式結束");
            Console.ReadKey();
        }

        public static void ex4_2()
        {
            Console.WriteLine("Ex4_2");
            Console.Write($"請輸入x：");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write($"請輸入y：");
            int y = Convert.ToInt32(Console.ReadLine());
            //int gcd = x;
            while (x != y)
            {
                if (x > y) { x = x - y; }
                else { y = y - x; }
            }

            Console.WriteLine($"最大公因數為{x}");
            Console.ReadKey();
        }

        public static void ex4_3()
        {
            Console.WriteLine("Ex4_3");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            int i = 0;
            while (i < num.Length)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            Console.WriteLine($"{n}個數字和為{num.Sum()}");
            Console.ReadKey();
        }


        public static void hw4_1()
        {
            Console.WriteLine("Hw4_1");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine()), i = 0;
            int[] num = new int[n];

            while (i < num.Length)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            Console.Write($"最大數值為：{num.Max()}");
            Console.ReadKey();
        }


        public static void hw4_2()
        {
            Console.WriteLine("Hw4_2");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine()), i = 0;
            Console.Write($"請輸入起始值值：");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"請輸入公差：");
            int d = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];

            while (i < num.Length)
            {
                num[i] = a1 + i * d;
                i++;
            }
            Console.Write($"等差級數和為：{num.Sum()}");
            Console.ReadKey();
        }

        public static void hw4_3()
        {
            Console.WriteLine("Hw4_3");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine()), i = 0;
            int[] num = new int[n];

            while (i < num.Length)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (num[i] > 12) { num[i] = 0; }
                i++;
            }
            Console.Write($"所有小於13之和為：{num.Sum()}");
            Console.ReadKey();
        }

        public static void hw4_4()
        {
            Console.WriteLine("Hw4_4");
            Console.Write($"請輸入N值：");
            int n = Convert.ToInt32(Console.ReadLine()), i = 0;
            int[] num = new int[n];

            while (true)
            {
                Console.Write($"請輸入第{i + 1}個數字：");
                num[i] = Convert.ToInt32(Console.ReadLine());
                if (num[i] > 7 && num[i] < 10) { break; }
                i++;
            }
            Console.Write($"第一個大於7小於10的數字為：{num[i]}");
            Console.ReadKey();
        }

        public static void hw4_5()
        {
            Console.WriteLine("Hw4_5");
            int[] a_arr = new int[5];
            int[] b_arr = new int[5];

            while (true)
            {
                Console.Write($"請輸入a1~a5值(ex 1 2 3 4 5)：");
                var a_input = Console.ReadLine();
                a_arr = a_input.Split(' ').Select(int.Parse).ToArray();
                if (a_arr.Length != 5)
                {
                    Console.WriteLine($"輸入格式錯誤，請重新輸入");
                }
                else { break; }
            }
            while (true)
            {
                Console.Write($"請輸入b1~b5值(ex 1 2 3 4 5)：");
                var b_input = Console.ReadLine();
                b_arr = b_input.Split(' ').Select(int.Parse).ToArray();
                if (b_arr.Length != 5)
                {
                    Console.WriteLine($"輸入格式錯誤，請重新輸入");
                }
                else { break; }
            }
            int i = 0;
            while (i < a_arr.Length)
            {
                if (a_arr[i] > b_arr[i])
                {
                    break;
                }
                i++;
            }
            Console.Write($"第一個a[i] > b[i]的i數字為：{i + 1}, a{i + 1}= {a_arr[i]}, b{i + 1}= {b_arr[i]}");
            Console.ReadKey();
        }

        public static void hw4_additional_1()
        {
            Console.WriteLine("Hw4_additional_1");
            Console.Write("請輸入Eric身上的金額：");
            int cash = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入吃漢堡時間(EX: 2014 05 28 14 23 42): ");
            var date_input = Console.ReadLine();
            int[] date_arr = date_input.Split(' ').Select(int.Parse).ToArray();

            DateTime date = new DateTime(date_arr[0], date_arr[1], date_arr[2], date_arr[3], date_arr[4], date_arr[5]);
            int hamburger = 39, minutes = 5;

            Console.WriteLine("吃漢堡紀錄為: ");
            while (cash >= hamburger)
            {

                Console.WriteLine(date);
                date = date.AddMinutes(minutes);
                cash -= hamburger;
            }
            Console.ReadKey();
        }

        public static void hw4_additional_2()
        {
            Console.WriteLine("Hw4_additional_2");
            int month = 0, home_loan = 5600000, repayment = 40000, bonus = 10000;

            while (home_loan > 0)
            {
                if (month % 12 == 0)
                {
                    home_loan -= (repayment + bonus);
                }
                else { home_loan -= repayment; }
                month++;
            }
            Console.Write($"共需要{month}個月還清房貸");
            Console.ReadKey();
        }

        public static void hw4_additional_3()
        {
            Console.WriteLine("Hw4_additional_3");
            Random rnd = new Random();
            int ans = rnd.Next(1, 1000), x, max = 1000, min = 1;

            while (true)
            {
                Console.Write($"請輸入要猜的數字 {min} < X < {max}：");
                x = Convert.ToInt32(Console.ReadLine());
                if (x > ans) { max = x; Console.WriteLine($"比{x}還小"); }
                else if (x < ans) { min = x; Console.WriteLine($"比{x}還大"); }
                else { Console.Write($"猜對了! X是{x}"); break; }
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            ex3_1();
            ex3_1_w();
            ex3_2();
            ex3_2_w();
            ex3_3();
            ex3_3_w();
            ex3_4();
            ex3_4_w();
            ex3_5();
            ex3_5_w();
            ex3_6();
            ex3_6_w();
            ex3_7();
            ex3_7_w();
            hw3_1();
            hw3_1_w();
            hw3_2();
            hw3_2_w();
            hw3_3();
            hw3_3_w();
            hw3_4();
            hw3_4_w();
            hw3_5();
            hw3_5_w();
            hw3_6();
            hw3_6_w();
            hw3_7();
            hw3_7_w();
            hw3_additional_1();
            hw3_additional_1_w();
            hw3_additional_2();
            hw3_additional_2_w();
            hw3_additional_3();
            hw3_additional_3_w();
            ex4_1();
            ex4_2();
            ex4_3();
            hw4_1();
            hw4_2();
            hw4_3();
            hw4_4();
            hw4_5();
            hw4_additional_1();
            hw4_additional_2();
            hw4_additional_3();
            Console.ReadKey();

        }
    }
}
