using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal abstract class Student
    {
        protected string name;
        protected int year;
        //phương thức khởi tạo
        public Student(string name,int year)
        {
            this.name = name;
            this.year = year;
        }
        //phươn thức hiển thị thông tin
        protected void Display()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Year: {0}",year);
        }
        //phương thức tính điểm trung bình
        public abstract double Average();
    }
}
