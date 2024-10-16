using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_3
{
    internal class StudentModel
    {
        //khai báo danh tập hợp chứa các sinh viên
        List<Student> liststudents;
        //phương thức khởi tạo
        public StudentModel()
        {
            //khởi tạo danh sách sinh viên
            this.liststudents = new List<Student>
            {
                new Student(){Id=1,Name="Dung",Age=20},
                new Student(){Id=2,Name="Long",Age=45},
                new Student(){Id=3,Name="Trường",Age=25},
                new Student(){Id=4,Name="Lâm",Age=35},
                new Student(){Id=5,Name="Tiến",Age=50},
            };
        }
        #region các phương thức overloading
        //phương thức trả về danh sách sinh viên
        public List<Student> GetStudents() { 
                return liststudents;
        }
        public Student GetStudent(int id) {
            Student st = null;
            foreach (var item in liststudents) {
                if (item.Id == id)
                    st = item;
            }
            return st;
        }
        //phương thức trả về sinh viên có tuổi từ x-y
        public List<Student> GetStudents(int x, int y) { 
            List<Student> result = new List<Student>();
            foreach (var item in liststudents) {
                if (item.Age >= x && item.Age <= y)
                    result.Add(item);
            }
            return result;
        }
        #endregion
    }
}
