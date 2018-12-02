using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Emp emp = new Emp("", 1, 1, 2);

            Console.WriteLine("inter your name");
            emp.name = Console.ReadLine();
            Console.WriteLine("inter you id");
            emp.id = Convert.ToInt32(Console.ReadLine());

            if ((emp.name != null) && (emp.id != null))
            {

                Console.WriteLine("please select type of employment");
                Console.WriteLine("1.Montnly employee");
                Console.WriteLine("2.Temporary employee");
                Console.WriteLine("3.Evenning employee");

                emp.type = Convert.ToInt32(Console.ReadLine());

                if (emp.type == 1)
                {

                    emp.salary(emp.gross_salary);

                }

                else if (emp.type == 2)
                {

                    emp.salary(emp.hours, emp.hour_salary);

                }

                else if (emp.type == 3)
                {

                    emp.salary(emp.hours, emp.hour_salary, emp.bonus, emp.net_before_bonus);

                }

                else Console.WriteLine(" invalid type of employment or invalid ID or name");
                Console.ReadLine();
            }
        }
    }
}


class employee
{
    public string name;
    public int id;
    public int type;
    public int gross_salary;
    public int net_salary;
    public int hours;
    public int hour_salary;
    public int bonus;
    public int net_salary_before_bonus;




    public employee(string aName, int aId, int atype, int aGross)

    {
        name = aName;
        id = aId;
        type = atype;
        gross_salary = aGross;
    }

    public void salary(int gross_salary)
    {
        Console.WriteLine("please enter monthly salary");

        gross_salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("employee name : " + name);
        Console.WriteLine("employee ID : " + id);
        Console.WriteLine("type of  employement : Monthly employement");
        Console.WriteLine("gross salary: " + gross_salary);
        Console.WriteLine("net salary " + (gross_salary - (gross_salary * 18) / 100));
    }


    public void salary(int hours, int hour_salary)
    {

        Console.WriteLine("Please enter your total  number of days you work");
        hours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter your daily salary");

        hour_salary = Convert.ToInt32(Console.ReadLine());


        gross_salary = (hours * hour_salary);
        net_salary = (gross_salary - (gross_salary * 18) / 100);

        Console.WriteLine("employee name : " + name);
        Console.WriteLine("employee ID : " + id);
        Console.WriteLine("type of  employement : Temporaly employement");
        Console.WriteLine("total number of hours: " + hours);
        Console.WriteLine("hour salary: " + hour_salary);
        Console.WriteLine("Gross salary: " + gross_salary);
        Console.WriteLine("net salary" + net_salary);

    }

    public void salary(int emp_evenning, int hour_salary, double bonus, int net_before_bonus)
    {
        Console.WriteLine("please enter  your total number of hours ");
        hours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("please enter  your hour salry ");

        hour_salary = Convert.ToInt32(Console.ReadLine());
        gross_salary = (hours * hour_salary);
        bonus = ((gross_salary * 0.15) / 100);


        net_before_bonus = (gross_salary - ((gross_salary * 18) / 100));
        net_salary = Convert.ToInt32(net_before_bonus + bonus);


        Console.WriteLine("employee name : " + name);
        Console.WriteLine("employee ID : " + id);
        Console.WriteLine("type of  employement : evening employment");
        Console.WriteLine("total number of hours: " + hours);
        Console.WriteLine("hour salary: " + hour_salary);
        Console.WriteLine("Gross salary: " + gross_salary);
        Console.WriteLine("net salary: " + net_salary);
    }

}