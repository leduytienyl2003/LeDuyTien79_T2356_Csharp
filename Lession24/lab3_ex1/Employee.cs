using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_ex1
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int yearOfBirth { get; set; }
        public double salaryLevel { get; set; }
        public double basicSalary {  get; set; }
        public double GetInCome()
        {
            double Income = (salaryLevel * basicSalary);
            return Income;
        }
        public void Display()
        {
            Console.WriteLine("Định danh:" + Id);
            Console.WriteLine("Tên:"+Name);
            Console.WriteLine("Năm sinh:"+yearOfBirth);
            Console.WriteLine("Lương cơ bản:"+basicSalary);
        }
    }
}
