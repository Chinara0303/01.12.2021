using System;
using System.Text;

namespace _1._12._21
{
    class Program
    {
        static void Main(string[] args)
        {

            //    Sum("Chinara", 'w');

            //    Console.WriteLine(Sumsr("Chinara", 'n'));

            //    Chinara("hello", 'w');


            //}

            //Console.WriteLine(Test("salam", 'l');


            //Console.WriteLine(Namespace(" world"));
            //Console.WriteLine(Countspaces("HELLO   BYE"));

            //Calculator(5, '/', 0);


        }
        //static void Sum(string word, char a)
        //{
        //    string result = String.Empty;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] == a)
        //        {
        //            result = " yes";
        //            break;
        //        }
        //        else
        //        {
        //            result = "no";
        //        }
        //    }
        //    Console.WriteLine(result);
        //}

        //static string Sumsr(string word1, char b)
        //{
        //    for (int i = 0; i < word1.Length; i++)
        //    {
        //        if (word1[i] == b)
        //        {
        //            return "yes";
        //            break;
        //        }
        //        else
        //        {
        //            return "no";
        //        }
        //    }
        //}

        //static void Chinara(string word2,char c)
        //{
        //    bool result = false;
        //    for (int i = 0; i < word2.Length; i++)
        //    {
        //        if (word2[i] == c)
        //        {
        //            result = true;

        //        }
        //    }
        //    if (result == true)
        //    {
        //        Console.WriteLine("yes");

        //    }
        //    else
        //    {
        //        Console.WriteLine("no");
        //    }


        //static bool Test(string word,char a)
        //{
        //    foreach (char item in word)
        //    {
        //        if (item==a)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        static int Namespace(string word)
        {
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {

                if (word[i] == ' ')
                {
                    count++;
                }


            }
            return count;
        }

        static int Countspaces(string word)
        {
            int count = 0;
            foreach (char item in word)
            {
                if (item == ' ')
                {
                    count++;
                }
            }
            return count;
        }

        //static int Calculator(int a,char p,int b)
        //{
        //    int result = 0;
        //    if (b==0)
        //    {
        //        Console.WriteLine("sehvsen!");



        //    }

        //    else
        //    {
        //        if (p == '+')
        //        {
        //            result = a + b;
        //        }
        //        else if (p == '-')
        //        {
        //            result = a - b;
        //        }
        //        else if (p == '*')
        //        {
        //            result = a * b;
        //        }
        //        else if (p == '/')
        //        {
        //            result = a / b;
        //        }
        //    }
        //    return result;







        static void Calculator(int a, char p, int b)
        {
            int result = 0;
            if (b == 0)
            {
                Console.WriteLine("sehvsen!");
            }

            else
            {
                if (p == '+')
                {
                    Console.WriteLine("a+b");
                }
                else if (p == '-')
                {
                    Console.WriteLine("a-b");
                }
                else if (p == '*')
                {
                    Console.WriteLine("a*b");
                }
                else if (p == '/')
                {
                    Console.WriteLine(a / b);
                }
                Console.WriteLine(result);
            }

        }
    }
}



