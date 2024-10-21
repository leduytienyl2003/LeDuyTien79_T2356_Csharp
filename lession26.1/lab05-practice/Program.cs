namespace lab05_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            //khởi tạo mảng 1 chiều gồm 10 phần tử student
            Student[] students = new Student[10];
            Random random = new Random();

            //điền thông tin cho sinh viên
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student
                {
                    Id = i + 1,
                    Name = "Student" + (i + 1),
                    Age = random.Next(18, 25) ///độ tuổi sinh viên từ 18-24
                };
            }
            //tìm phần tử student có tuổi nhỏ nhất
           Student youngestStudent = FindYoungestStudent(students);
            Console.WriteLine($"sinh viên có tuổi nhỏ nhất: {youngestStudent}");

            //sắp xếp mảng tăng dần thoe từng độ tuổi sinh viên
            SortStudentsByAge(students);
            Console.WriteLine("danh sách sinh viên sau khi sắp xếp tuổi:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            //tìm sinh viên có độ tuổi lớn nhất
            Student oldestStudent = FindOldestStudent(students);
            Console.WriteLine($"sinh viên có tuổi lớn nhất: {oldestStudent}");
        }
        static Student FindYoungestStudent(Student[] students)
        {
            Student youngest = students[0];
            foreach (var student in students)
            {
                if (student.Age < youngest.Age)
                {
                    youngest = student;
                }
            }
            return youngest;
        }
        static void SortStudentsByAge(Student[] students)
        {
            Array.Sort(students, (s1, s2) => s1.Age.CompareTo(s2.Age));
        }
        static Student FindOldestStudent(Student[] students)
        {
            Student oldest = students[0];
            foreach (var student in students) {
                if (student.Age > oldest.Age)
                {
                    oldest = student;
                }
            }
            return oldest;
        }
    }
}
