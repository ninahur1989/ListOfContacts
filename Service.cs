using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfContacts
{
    public class Service
    {
        public void Writer(List<string> a, List<string> b)
        {
            ListContainer listContainer = new ListContainer();
            List<string> num = listContainer._num;
            for (int i = 0; i < a.Count; i++)
            {
                char[] chars1 = a[i].ToCharArray();
                if (i == 0)
                {
                    Console.WriteLine("\t" + chars1[0].ToString().ToUpper());
                }
                else
                {
                    char[] chars2 = a[i - 1].ToCharArray();
                    if (char.ToLower(chars1[0]) != char.ToLower(chars2[0]))
                    {
                        Console.WriteLine("\t" + chars1[0].ToString().ToUpper());
                        Console.WriteLine(a[i]);
                    }
                    else
                    {
                        Console.WriteLine(a[i]);
                    }
                }
            }

            Console.WriteLine("\t" + "#");
            foreach (string s in b)
            {
                Console.WriteLine(s);
            }

            foreach (string s in num)
            {
                Console.WriteLine(s);
            }
        }
    }
}