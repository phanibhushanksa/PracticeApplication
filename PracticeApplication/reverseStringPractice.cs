using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace PracticeApplication
{
    class reverseStringPractice
    {

        public static void Main()
        {
            char[] inp = new char[] {'a' , 'b' , 'c' , 'a' , 'b' , 'c' };
            int k = 2;
            bool flag = false;
            Dictionary<char, List<int>> dict = new Dictionary<char, List<int>>();
            List<int> tempList = new List<int>();
           
            

            for (int i = 0; i < inp.Length; i++)
            {
                List<int> uniqueList = new List<int>();
                if (!dict.ContainsKey(inp[i]))
                {
                    
                    uniqueList.Add(i);
                    dict.Add(inp[i], uniqueList);
                }
                else
                {
                    tempList = dict[inp[i]];
                    tempList.Add(i);
                    dict[inp[i]] = tempList;

                }
                
            }
            foreach(var temp in dict)
            {
                if (temp.Value.Count > 1)
                {
                    for (int i = 0; i < temp.Value.Count - 1; i++)
                    {
                        if ((temp.Value[i + 1] - temp.Value[i]) <= k)
                        {
                            flag = true;
                            break;
                        }
                       
                    }
                    if (flag == true)
                        break;
                }
            }
            Console.WriteLine(flag);
        }

    }
}
