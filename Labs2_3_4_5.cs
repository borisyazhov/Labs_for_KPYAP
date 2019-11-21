using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        public static double Laba_2(double cash, double kaef)
        {
            return (cash * kaef) / (1 - kaef);
        }
        public static bool FormValue(int a, int b)
        {
            return a % 10 + (a / 10) % 10 + (a / 100) % 10 == b;
            

        }
        public static void Laba_2_1()
        {
            for (int i = 100; i != 1000; ++i)
            {
                if (FormValue(i, 27))
                {
                    Console.WriteLine(i);
                }
                    
            }
        }
        public static void Laba_3_1(double k, double n)
        {
            double h = (k - n) / 10;
               
            for(double x = k; x < n; x -= h)        
            {
               Console.WriteLine(Math.Log10(1 / (2 + 2 * x + Math.Pow(x, 2))));
            }
        }
        public static void Laba_3_2(int n)
        {
            int[] arr = { 1, 2, 3, 4, 10, 12, 13, -1, -3 };
            int count = 0;
            if(n > 0)
            {
                for(int i = 1; i != n; ++i )
                {
                    if(arr[i] < 0)
                    {
                        count++;
                    }

                }

            }
            else
            {
                 Console.WriteLine("False");
            }
            Console.WriteLine(count);
        }
         
       
        struct MyStruct
        {
           
            public int proizv, a, b;
        }
    
    public static void Laba_4_1(int[] arr)
        {
          
            var temp = new MyStruct[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    temp[i].proizv = arr[i] * arr[j];
                    temp[i].a = arr[i];
                    temp[i].b = arr[j];
                }

            }
            
            var min = temp.OrderBy(a => a.proizv).First();
            var max = temp.OrderByDescending(a => a.proizv).First();
            Console.WriteLine("{0}*{1}={2}", min.a, min.b, min.proizv);
            Console.WriteLine("{0}*{1}={2}", max.a, max.b, max.proizv);

        }

        public static void Laba_4_2(int[]arr)
        {
            int n = 0;
            int sum = 0;
            for(int i = 0; i < arr.Length; ++i)
            {
                if(arr[i] < 0)
                {
                    n = i;
                    break;
                }
            }
            for(int j = n + 1; j < arr.Length; ++j)
            {
                sum += Math.Abs(arr[j]);
                
            }
            Console.WriteLine(sum);
        }

        public static int laba_5_1(String str)
        {
            int count = 0;
            int temp = 0;
            str = str.ToLower();
            for(int i = 0; i < str.Length; ++i)
            {
                if(str[i] != ' ')
                {
                    if(str[i] == 'а')
                    {
                        ++temp;
                    }
                }
                else
                {
                    temp = 0;
                    continue;
                }
                if(temp == 3)
                {
                    ++count;
                    temp = 0;
                }
            }
            return count;
        }

        public static int laba_5_2(String str)
        {
            int count = 0;
            int temp = 0;
            str = str.ToLower();
            str = str.Trim();
            String[] a = str.Split(' ');
            foreach(String i in a)
            {
                foreach(char j in i)
                {
                    if(j == 'а')
                    {
                        ++temp;
                    }
                }
                if(temp == 3)
                {
                    ++count;
                }
                temp = 0;
            }
            return count;
        }
        
      public static int Labs_Tests(String str)
        {
            int count = 0;
            int temp = 0;
            for(int i = 0; i < str.Length; ++i)
            {
                if(str[i] != ' ')
                {
                    ++temp;
                }
                else
                {
                    if(temp > count)
                    {
                        count = temp;
                    }
                    temp = 0;
                }
            }
            return count;

        }
        public static int Laba_Tests(String str)

        {
            int count = 0;
            int temp = 0;
            String[] a = str.Split(' ');
            for(int i = 0; i > str.Length; ++i)
            {
                temp = a[i].Length;
                if(temp > count)
                {
                    count = temp;
                }
                temp = 0;
            }
            return count;
        }
        public static String Laba_Tests_1(String str)
        {
            StringBuilder str_1 = new StringBuilder(str);
            for(int i = 0; i < str.Length; ++i)
            {
                if (str[i] == ' ' && str[i + 1] == ' ')
                {
                    str_1.Remove(i, 1);
                }
            }
            return str_1.ToString();
             
        }
        public static String Laba_Tests_()
        static void Main(string[] args)
        {

            //var arr = new int[] { -32, -1, 0, 3, 4, 45 };
            String str = "ывозщып вызщпоаыщапвА   зщвыапщаыоапвщ вызщпо";
            //Console.WriteLine(laba_5_1(str)); 
            //Console.WriteLine(laba_5_2(str));
            Console.WriteLine(Laba_Tests_1(str));
            //Laba_4_2(arr);
            //Laba_4_1(arr);
           // Laba_3_2(9);
            //Laba_3_1(-2, -0.1);
            //Console.WriteLine(Laba_2(2700, 0.13));
            //Laba_2_1();
            
            Console.ReadKey();
        }
    }
}
