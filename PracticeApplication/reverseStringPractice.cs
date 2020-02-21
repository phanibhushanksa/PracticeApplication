using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace PracticeApplication
{
    class reverseStringPractice
    {
        public static List<List<int>> li = new List<List<int>>();
        public static int q =  new int();
        public static void Main()
        {   
            
            int n = 5;
           
            //int[] arr = new int[] { };
            //for(q = 1; q<n;q++)
            //{
                myRecur(n);
                
            //}   

        }
        public static int myRecur(int a) 
        {
            try
            {
                if (a == 1)
                {
                    //Console.WriteLine(a);

                    return a;
                    // tempList.Add(a);
                    // reverseStringPractice.li.Add(tempList);
                }
                else              
                {
                    for (int i = 1; i <=a; i++)
                    {
                      
                        Console.WriteLine("{0} {1}", i, a-i);
                        if (a - i == 1)
                        {
                            continue;
                        }
                        else
                        {
                            return myRecur(a - i);
                        }
                    }
                    
                }
                return 1;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return default; 
            }
               
        }
    }
}
