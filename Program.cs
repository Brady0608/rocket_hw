using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW3
{
    internal class Program
    {
        public static void Ex6_1() {

            string prefix = "Hi~";
            Console.Write("Input a name:");
            string str = Console.ReadLine();
            Console.WriteLine(prefix + str);
        
        }
        public static void Ex6_2() {

            string check_sentence = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
            Console.Write("Input a word:");
            string str = Console.ReadLine();
            string result = check_sentence.IndexOf(str) != -1 ? $"{str}在字串裡" : $"{str}不在字串裡";
            Console.WriteLine(result);

        }
        public static void Ex6_3() {

            Console.Write("Input a string:");
            string str = Console.ReadLine();
            int counts = str.Length - 1;
            int j = 0;
            for (int i = 0; i < counts; i++) {str = str.Insert(j+1, "-"); j += 2;}
            Console.WriteLine(str);
        }
        public static void Ex6_4() {
            Console.Write("Input a filename:");
            string str = Console.ReadLine();
            Console.WriteLine("副檔名為:" + str.Substring(str.IndexOf(".")+1));
        }
        public static void Ex6_5() {
            Console.Write("Input a word:");
            string str = Console.ReadLine();
            string result = str.Length>=5 ? $"前3字為:{str.Substring(0,3)}" : $"長度不夠";
            Console.WriteLine(result);
        }
        public static void Ex6_6() {
            string change_word = "小明", original_word = "我";
            Console.Write("Input a string:");
            string str = Console.ReadLine();
            Console.WriteLine(str.Replace(original_word,change_word));


        }
        public static void Ex6_7() {
            Console.Write("Input a string:");
            string str = Console.ReadLine();
            Console.WriteLine($"總共輸入{str.Length}個字");
        }
      
        public static void Additional_6_1() {
            int array_range = 10;
            string[] strings = new string[array_range];
            int i = 0;
            while(i < array_range)
            {
                Console.Write("Input a string:");
                string str = Console.ReadLine();
                string result = strings.Contains(str) ? $"{str}已輸入過" : $"{str}未輸入過";
                Console.WriteLine(result);
                strings[i] = str;
                i++;
            }
        }
        public static void Additional_6_2() {
            Console.Write("Input a string:");
            string str = Console.ReadLine();
            string[] result = new string[str.Length];
            for(int i = 0; i < result.Length; i++)
            {
                str = str.ToLower();
                result[i] = str.Substring(0,i) + str[i].ToString().ToUpper() + str.Substring(i + 1);
                Console.WriteLine(result[i]);
            }
        }
        public static void Additional_6_3() {
            Console.Write("Input a TIME (EX: 11:30):");
            string str = Console.ReadLine();
            string[] result = str.Split(':');
            Console.WriteLine($"{result[0]}點{result[1]}分");

        }
        public static void Additional_6_4() {
            Console.Write("Input a string (EX: Justin,Amy,David):");
            string str = Console.ReadLine();
            string[] result = str.Split(',');
            Console.WriteLine("<ul>");
            foreach(string s in result)
            {
                Console.WriteLine($"\t <li>{s}</li>");
            }
            Console.WriteLine("</ul>");


        }
        public static void Additional_6_5() {
            int[] ints = new int[5];

            while(true)
            {
                Console.Write($"Input 5 numbers (ex 1 2 3 4 5)：");
                string a_input = Console.ReadLine();
                
                ints = a_input.Split(' ').Select(int.Parse).ToArray();
                if( ints.Length !=5 ) { Console.WriteLine($"輸入格式錯誤，請重新輸入"); }
                else { break; }
            }
            Console.WriteLine($"數字和為{ints.Sum()}");
        }
        public static void Additional_6_6() {
            Console.Write($"Input a string：");
            string str = Console.ReadLine();
            Console.WriteLine($"{new string(str.Reverse().ToArray())}");

        }

        public static void Ex7_1() {
            Console.Write($"Input a string：");
            string str = Console.ReadLine();
            str = str.Replace(">", "&gt;").Replace("<","&lt;").Replace(@"\r","<br>").Replace(@"\n","<br>").Replace("|","&brvbar;").Replace(" ","&nbsp");
            Console.WriteLine(str);

        }
        public static void Ex7_2() {
            Console.Write($"Input a string：");
            string str = Console.ReadLine();
            string pattern = @"^\d+[.]?\d*$";
            Regex num_check = new Regex(pattern);
            string message = num_check.IsMatch(str) ? $"{str}為數字" : $"{str}不為數字";
            Console.WriteLine(message);
        }
            
        public static void Ex7_3() {
            Console.Write($"Input an E-mail：");
            string str = Console.ReadLine();
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex num_check = new Regex(pattern);
            string message = num_check.IsMatch(str) ? $" {str} email格式正確" : $" {str} email格式錯誤";
            Console.WriteLine(message);
        }
        public static void Ex7_4() {
            Console.Write($"Input a Phone Number：");
            string str = Console.ReadLine();
            string pattern = @"^09\d{8}";
            Regex num_check = new Regex(pattern);
            string message = num_check.IsMatch(str) ? $" {str} 手機格式正確" : $" {str} 手機格式錯誤";
            Console.WriteLine(message);

        }
        public static void Ex7_5() {
            Console.Write($"Input a ID Number：");
            string str = Console.ReadLine();
            string pattern = @"^[A-Za-z]\d{9}$";
            Regex num_check = new Regex(pattern);
            string message = num_check.IsMatch(str) ? $" {str} 身分證格式正確" : $" {str} 身分證格式錯誤";
            Console.WriteLine(message);

        }
        public static void Ex7_6() {
            Console.Write($"Input N：");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Input a string：");
            string str = Console.ReadLine();
            char[] chars = str.ToCharArray();
            for ( int i = limit; i < chars.Length; i++ )
            {
                chars[i] = '.';
            }
            Console.WriteLine(new string(chars));

        }
        public static void Ex7_7() {
            Console.Write($"Input a datetime (EX: 2024.01.26)：");
            string str = Console.ReadLine();
            int[] date = str.Split('.').Select(int.Parse).ToArray();
            Console.WriteLine($"民國{date[0] - 1911}年{date[1]}月{date[2]}日");

        }
        public static void Ex7_8() {
            Console.Write($"Input a datetime (EX: 2024.01.26)：");
            string str = Console.ReadLine();
            int[] date = str.Split('.').Select(int.Parse).ToArray();
            DateTime dt = new DateTime(date[0], date[1], date[2]);
            Console.WriteLine($"民國{date[0] - 1911}年{date[1]}月{date[2]}日 {dt.DayOfWeek}");

        }
        public static void Ex7_9() {
            Console.Write($"Input a year (EX: 2024)：");
            int year =Convert.ToInt32(Console.ReadLine());
            string message;
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                message = $"{year}是閏年";
            }else
            {
                message = $"{year}不是閏年";
            }

            Console.WriteLine(message);
        }
        public static void Ex7_10() {
            Console.Write($"Input a Phone Number：");
            string num = Console.ReadLine();
            double result = Convert.ToDouble(num.Substring(6));
            result = result / 80;
            double fractionalPart = result - Math.Truncate(result);
            Console.WriteLine($"幸運數值為{fractionalPart*80}");

        }


        static void Main(string[] args)
        {
            //Ex6_1();
            //Ex6_2();
            //Ex6_3();
            //Ex6_4();
            //Ex6_5();
            //Ex6_6();
            //Ex6_7();
            //Additional_6_1();
            //Additional_6_2();
            //Additional_6_3();
            //Additional_6_4();
            //Additional_6_5();
            //Additional_6_6();

            //Ex7_1();
            //Ex7_2();
            //Ex7_3();
            //Ex7_4();
            //Ex7_5();
            //Ex7_6();
            //Ex7_7();
            //Ex7_8();
            //Ex7_9();
            Ex7_10();

            Console.ReadKey();

        }
    }
}
