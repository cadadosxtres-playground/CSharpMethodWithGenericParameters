using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


/*
 * Program to test how works generic types in C#
 * 
 */

namespace GenericTypesTest
{
    class TestGenericsTypes
    {
        private Boss bossy;

        public Boss Bossy
        {
            get { return bossy; }
            set { bossy = value; }
        }

        
        private List<Employee> employees = new List<Employee>();

        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        static void Main(string[] args)
        {
            TestGenericsTypes program = new TestGenericsTypes();
            Employee e = program.generateEmployee("Paco Pérez", 41);
            program.genericToString<Employee>("Employee:", ref e);
            Boss b = program.generateBoss("Javer Pérez", 50);
            program.genericToString<Boss>("Boss:", ref b);
            program.toStringJerarquia(program.Bossy);
            
        }

        public Employee generateEmployee(string name, int age )
        {
            Employee employee = new Employee(name, age);
            Employees.Add(employee);
            //Console.WriteLine(String.Format("Empleado: {0}", employee.ToString()));
            return employee;

        }

        public Boss generateBoss(string name, int age) 
        {
            Boss boss = new Boss(name, age);
            Bossy = boss;
            if (Employees != null)
            {
                Bossy.Employees = Employees;
            }
            return boss;
            //Console.WriteLine(String.Format("Jefe: {0}", boss.ToString()));
        }

        public void toStringJerarquia(Boss boss) 
        {
            Console.WriteLine(String.Format("Orgranigrama: \n {0}", boss.ToString()));
        }

        /*
         * Method wich recive generic type
         */
        public void genericToString<T>(string message, ref T t) 
        {
            Console.WriteLine(message + " {0}", t.ToString());
        }
    }
}
