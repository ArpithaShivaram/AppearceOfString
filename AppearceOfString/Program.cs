using System;
namespace AppearceOfString
{
    class  Appstring
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("caabb"));
            Console.WriteLine(test("babaaba"));
            Console.WriteLine(test("aaaaa"));
            Console.ReadLine();
        }
        public static bool test(string str)
        {
            var counter = 0;
            for (var i = 0; i < str.Length - 1; i++)
            {
                if (str[i].Equals('a')) counter++;
                if (str.Substring(i, 2).Equals("aa") && counter < 2)
                    return true;
            }

            return false;
        }
    }
}
