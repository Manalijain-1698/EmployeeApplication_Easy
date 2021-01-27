using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //1.
            List<string> EmployeeNames = new List<string>();       //Empty list of employeenames
            Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion(Please enter blank to stop)");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Employee Name:");
                string Empname = Console.ReadLine();
                EmployeeNames.Add(Empname);                        //Adding employee names to the list

            }

            EmployeePromotion ep = new EmployeePromotion();        //object instantiation
            List<string> List_of_EmpNames = ep.EmployeeNames(EmployeeNames);
            foreach (string ename in List_of_EmpNames)
            {
                Console.WriteLine(ename);                          //Printing all the employee names
            }
            //2.

            Console.WriteLine("Please enter the name of the employee to check promotion position");
            string KeyName = Console.ReadLine();

            int pos = EmployeeNames.IndexOf(KeyName);               //position of pariticular keyname
            Console.WriteLine("{0} is the the position {1} for promotion.", KeyName, pos + 1);

            //3.
            Console.WriteLine("The current size of the collection is {0}", EmployeeNames.Capacity);
            EmployeeNames = EmployeeNames.Select(t => t.Trim()).ToList();
            
            Console.WriteLine("The size after removing the extra space is  {0}", EmployeeNames.Count);




            //4.
            Console.WriteLine("Promoted employee list:");
            EmployeeNames.Sort();                                    //sorting the list in ascending order
            EmployeeNames.ForEach(Name => Console.WriteLine(Name + " "));











        }
    }
}
