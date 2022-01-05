using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonInterface; // CustomNamespace
using EmployeeNamespace; //CustomNamespace

namespace PersonInterface // Interface
{
    public interface IPerson
    {
        string employee_name { get; set; }
        double hours_worked { get; set; }
        double overtime { get; set; }
        void setInfo(string Ename, double Hworked, double Otime);
    }

}

namespace EmployeeNamespace
{
    //get and set methods and classes and objects
    public class Employee : IPerson
    {
        public string employee_FName;
        public double employee_hours;
        public double employee_overtime;


        public string employee_name
        {
            get
            {
                return employee_FName;
            }
            set
            {
                employee_FName = value;
            }
        }

        public double hours_worked
        {
            
            get {
                return employee_hours;
            }
            set
            {
                employee_hours = value;
            }
        }
         public double overtime
        {
            get
            {
                return employee_overtime;
            }
            set
            {
                employee_overtime = value;
            }
        }

        public void setInfo(string Ename, double Hworked, double Otime)
        {
            this.employee_name = Ename;
            this.hours_worked = Hworked;
            this.overtime= Otime;
        }
    }
}

namespace SimplePayroll35
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 10; i++)
            {

                Console.WriteLine("====================================");
                Console.WriteLine("======Employee Payroll System=======");
                Console.WriteLine("====================================");
                Console.WriteLine("");

           
                Console.Write("Enter Emplyee Name: ");
                string nameInput = Console.ReadLine();

                Console.Write("Enter Hours Worked: ");
                int HoursInput = int.Parse(Console.ReadLine());

                Console.Write("Enter Overtime: ");
                int OTInput = int.Parse(Console.ReadLine());


                Employee s1 = new Employee();
                s1.employee_name = nameInput;
                s1.hours_worked = HoursInput;
                s1.overtime = OTInput;

                Console.WriteLine("----------------------------");
                Console.WriteLine("A. IT Department");
                Console.WriteLine("B. Accounting and Finance");
                Console.WriteLine("C. Marketing");
                Console.WriteLine("----------------------------");

                Console.Write("Enter Your Department: ");
                string dept = Console.ReadLine();


                if (dept.Equals("A"))
                {
                    //Constant Value of Salary Perhour in IT Department is 80 pesos
                    int totalHours = HoursInput * 80;
                    int totalOvertime = OTInput * 80;
                    Console.WriteLine(" ");

                    Console.WriteLine("===================================");
                    Console.WriteLine("Employee name: " + nameInput);
                    Console.WriteLine("Salary Per One Day: " + totalHours);
                    Console.WriteLine("Overtime: " + totalOvertime);
                    Console.WriteLine("===================================");
                    
                    Console.WriteLine("===================================");
                    int totalSalaryPerday = totalHours + totalOvertime;
                    //30 days or 1 month
                    Console.WriteLine("Total Salary Per Month: " + totalSalaryPerday * 30);
                    Console.WriteLine("===================================");
                    Console.WriteLine("");
                }

                else if (dept.Equals("B"))
                {
                    //Constant Value of Salary Perhour in Accounting and Finance is 70 pesos
                    int totalHours = HoursInput * 70;
                    int totalOvertime = OTInput * 70;
                    Console.WriteLine(" ");

                    Console.WriteLine("===================================");
                    Console.WriteLine("Employee name: " + nameInput);
                    Console.WriteLine("Salary Per One Day: " + totalHours);
                    Console.WriteLine("Overtime: " + totalOvertime);
                    Console.WriteLine("===================================");

                    Console.WriteLine("===================================");
                    int totalSalaryPerday = totalHours + totalOvertime;
                    //30 days or 1 month
                    Console.WriteLine("Total Salary Per Month: " + totalSalaryPerday * 30);
                    Console.WriteLine("===================================");
                    Console.WriteLine("");
                }

                else if (dept.Equals("C"))
                {
                    //Constant Value of Salary Perhour in Marketing is 50 pesos
                    int totalHours = HoursInput * 50;
                    int totalOvertime = OTInput * 50;
                    Console.WriteLine(" ");

                    Console.WriteLine("===================================");
                    Console.WriteLine("Employee name: " + nameInput);
                    Console.WriteLine("Salary Per One Day: " + totalHours);
                    Console.WriteLine("Overtime: " + totalOvertime);
                    Console.WriteLine("===================================");

                    Console.WriteLine("===================================");
                    int totalSalaryPerday = totalHours + totalOvertime;
                    //30 days or 1 month
                    Console.WriteLine("Total Salary Per Month: " + totalSalaryPerday * 30);
                    Console.WriteLine("===================================");
                    Console.WriteLine("");
                }

                else
                {
                    Console.WriteLine("Wrong Input");
                }              
            }
            Console.ReadLine();
        }}
    }
