using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_HashMap_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> phoneBook = new Dictionary<string, int>(n);

            for (int i=0;i<n;i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                if(temp[1].Length == 8)
                {
                    phoneBook.Add(temp[0], Convert.ToInt32(temp[1]));
                }
            }
            string searchName = "";

            while ((searchName = Console.ReadLine()) != null)
            {
                int flag = 0;
                if (searchName != "")
                {
                    if (phoneBook.ContainsKey(searchName))
                    {
                        flag = 1;
                    }
                }
                if (flag == 1)
                {
                    Console.WriteLine(searchName + " --> " + phoneBook[searchName]);
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }

        }
    }
}
