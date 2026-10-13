using System;
using System.Collections.Generic;

namespace DSA_Activity_51_Estrada_JanLaurence
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                var word = new Stack<char>();
                Console.WriteLine("PALINDROME PROGRAM");
                Console.WriteLine("Enter 0 to exit.");

                string s = "N";
                int a = 1;
                while ( a != 0)
                {
                    Console.Write("Enter word: ");

                    s = Console.ReadLine();


                    for (int i = 0; i < s.Length; i++)
                    {
                        word.Push(s[i]);
                    }

                    bool b = true;
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] != word.Pop())
                        {
                            b = false;
                        }
                    }

                    if (b != false)
                    {
                        Console.WriteLine("It is PALINDROME");

                    }
                    else 
                    { 
                        Console.WriteLine("It is NOT PALINDROME"); 
                    }
                }

            }

            catch (Exception e)
            {
                Console.WriteLine("Error Encountered " + e.ToString());
            }
            finally
            {
                Console.ReadKey();
            }


        }

    }

}

