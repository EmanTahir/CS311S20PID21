using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "", str2 = "001111011000";
            int i = 0, count1 = 0, count0 = 0, n = str2.Length;
            for (i = 0; i < n; i++)
            {
                if ((Char.Equals(str2[i], '1') == true))
                {
                    count1++;
                    if ((i + 1) == n || Char.Equals(str2[i + 1], '0') == true)
                    {

                        if (count1 >= 1)
                        {

                            //write to file count1 and 1
                            str1 = str1 + count1 + "1";
                            count1 = 0;
                        }

                    }
                }



                else
                {
                    count0++;
                    if ((i + 1) == n || Char.Equals(str2[i + 1], '1') == true)
                    {


                        if (count0 >= 1)
                        {
                            str1 = str1 + count0 + "0";
                            count0 = 0;
                        }
                    }
                }
            }

            Console.WriteLine(str1);
            Console.Read();
        }

    }
}
