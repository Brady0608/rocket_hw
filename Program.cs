using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_sharp_lesson2
{
    internal class Program
    {
        public static void Hw2_1()
        {   
            Console.Write("Hw2_1\nInput x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > y)
                Console.Write(x);
            else
                Console.Write(y);
            Console.ReadLine();
        }
        public static void Hw2_2()
        {
            Console.Write("Hw2_2\nInput x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double z;
            if (x > 0 && y > 0)
                z = 1;
            else if (x < 0 && y < 0)
                z = -1;
            else
                z = 0;
            Console.Write(z);
            Console.ReadLine();
        }

        public static void Hw2_3()
        {
            Console.Write("Hw2_3\nInput x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input u: ");
            double u = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input v: ");
            double v = Convert.ToDouble(Console.ReadLine());
            double z;
            if ((x+y)>(u+v))
                z = x-y;
            else
                z = u-v;
            Console.Write(z);
            Console.ReadLine();
        }

        public static void Hw2_4()
        {
            Console.Write("Hw2_4\nInput x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input u: ");
            double u = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input v: ");
            double v = Convert.ToDouble(Console.ReadLine());
            double z;
            if ((x + y)/(u - v) >= 2)
                z = x - y;
            else
                z = u - v;
            Console.Write(z);
            Console.ReadLine();
        }
        public static void Hw2_5()
        {
            Console.Write("Hw2_5\nInput x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x >= y)
                Console.Write(Math.Pow(x, 2.0));
            else
                Console.Write(Math.Pow(y, 2.0));
            Console.ReadLine();
        }

        public static void Hw2_6()
        {
            Console.Write("Hw2_6\nInput income: ");
            double income = Convert.ToDouble(Console.ReadLine());
            double[] rate = { 0.4, 0.3, 0.21, 0.13, 0.06 }, diff = { 721100, 312100, 115900, 28700, 0 }
            , income_border = { 4090000, 2180000, 1090000, 410000 };
            double tax = 0;
            for (int i = 0; i < income_border.Length; i++) {
                if (income > income_border[i]) { tax = (income * rate[i]) - diff[i]; break; }
                else { tax = (income * rate[i+1]) - diff[i+1]; }
            }
            Console.Write(("tax=" + tax));
            Console.ReadLine();
        }


        public static void Hw2_7()
        {
            Console.Write("Hw2_7\nInput x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0) { 
                if (y > 0) { Console.Write("1st quadrant\n"); }
                else if (y == 0) { Console.Write("X-axis\n"); }
                else { Console.Write("4th quadrant\n"); }
            }
            else if(x == 0){                
                if (y == 0) { Console.Write("Orgin\n"); }
                else { Console.Write("Y-axis\n"); }
            }
            else {
                if (y > 0) { Console.Write("2nd quadrant\n"); }
                else if (y == 0) { Console.Write("X-axis\n"); }
                else { Console.Write("3th quadrant\n"); }
            }
            Console.ReadLine();
        }

        public static void Additional_hw_1()
        {
            Console.Write("Additional_hw_1\nInput the nubmer of solved problems: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int score;
            if (x <= 10){score = x * 6;}
            else if (x <= 20){score = 10 * 6 + (x - 10) * 2;}
            else if (x <= 40){score = 10 * 6 + 10 * 2 + (x - 20);}
            else {score = 100;}
                Console.Write(("Score: " + score));
            Console.ReadLine();

        }

        public static void Additional_hw_2()
        {
            Console.Write("Additional_hw_2\nInput your height (cm): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input your weight (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double bmi = Math.Round(weight / Math.Pow(height/100, 2),2);

            if (bmi > 24) { Console.Write("BMI: " + bmi +"\n OVERWEIGHT!"); }
            else if (bmi >= 18) { Console.Write("BMI: " + bmi + "\n NORMAL"); }
            else { Console.Write("BMI: " + bmi + "\n SKINNY!"); }
            Console.ReadLine();
        }

        public static void Additional_hw_3()
        {
            double[] num = new double[3];
            Console.Write("Additional_hw_3\nInput 3 number: ");
            for (int i = 0; i < num.Length; i++) { num[i] = Convert.ToDouble(Console.ReadLine()); }
             Array.Sort(num);
            for (int i = 0; i < num.Length; i++) { Console.Write($" {num[i]}"); }
            Console.ReadLine();
        }

        public static void Additional_hw_4()
        {
            Console.Write("Additional_hw_4\nInput profit: ");
            double profit = Convert.ToDouble(Console.ReadLine());
            double bonus;
            if (profit <= 100000) { bonus = profit * 0.1; }
            else if (profit <= 200000) { bonus = 100000 * 0.1 + (profit - 100000) * 0.075; }
            else if (profit <= 400000) { bonus = 100000 * 0.1 + 100000 * 0.075 + (profit-200000)*0.05;}
            else if (profit <= 600000) { bonus = 100000 * 0.1 + 100000 * 0.075 + 200000 * 0.05 + (profit - 400000) * 0.03; }
            else if (profit <= 1000000) { bonus = 100000 * 0.1 + 100000 * 0.075 + 200000 * 0.05 + 200000*0.03 + (profit - 600000) * 0.015;}
            else { bonus = 100000 * 0.1 + 100000 * 0.075 + 200000 * 0.05 + 200000 * 0.03 + 400000*0.015 + (profit - 1000000) * 0.01; }
            Console.Write(("Bonus: " + bonus));
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Hw2_1();
            Hw2_2();
            Hw2_3();
            Hw2_4();
            Hw2_5();
            Hw2_6();
            Hw2_7();
            Additional_hw_1();
            Additional_hw_2();
            Additional_hw_3();
            Additional_hw_4();

        }
    }
}
