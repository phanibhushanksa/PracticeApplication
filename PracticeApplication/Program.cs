using System;
using System.Collections.Generic;



namespace PracticeApplication
{
    class Program
    {
        
        static void Main2(string[] args)
        {

            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { Exp = 5, ID = 1, Name = "Phani", Salary = 1500000 });
            empList.Add(new Employee() { Exp = 3, ID = 3, Name = "Rudraa", Salary = 2000000 });
            empList.Add(new Employee() { Exp = 2, ID = 5, Name = "Srinivas", Salary = 1000000 });
            empList.Add(new Employee() { Exp = 4, ID = 7, Name = "Bhushan", Salary = 9000000 });

            //using delgates with lamda expressions. 
            //here the second parameter of the promotionCheck method is PromotionDelegate type, which inturn takes type Employee as 
            //input parameter.
            Employee.promotionCheck(empList, emp => emp.Exp>2);

            //using delegates with methods.
            Employee.promotionCheck(empList, promoCheckMethod1);

            //initializing an instance of delegate
            PromotionDelegate promDel = new PromotionDelegate(promoCheckMethod1);
            //passing the delegate as a paramaeter the method.
            Employee.promotionCheck(empList, promDel);
        }

        public static bool promoCheckMethod1(Employee emp)
        {
            if (emp.Exp > 2)
                return true;
            else
                return false;
        }

        public static bool promoCheckMethod2(Employee emp)
        {
            if (emp.Salary > 1500000)
                return true;
            else
                return false;
        }

    }

    //Step 1 Create a delegate, based on the return type and input we want to replace and decouple.
    delegate bool PromotionDelegate(Employee empl);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Exp { get; set; }
        
        //passing the method or delegate or lamda expression as a parameter. Doing so, we can dyamically pass our own function and
        //declare our own criteria for promotion.
        public static void promotionCheck(List<Employee> empList, PromotionDelegate isPromotable)
        {
            foreach(Employee emp in empList)
            {
                if(isPromotable(emp))
                {
                    Console.WriteLine("{0} is promoted",emp.Name);
                }
            }
        }
    }
}
