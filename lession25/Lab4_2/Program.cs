namespace Lab4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            //khởi tạo sinh viên cao đẳng và in ra thông tin
            Console.WriteLine("Student of College:");
            StudentCollege sv1 = new StudentCollege("Tiến",2003,9,8,7);
            sv1.Display();
            Console.WriteLine("Average of score: {0}", sv1.Average());
            //khởi tạo sinh viên đại học và in ra thông tin
            Console.WriteLine("student of university:");
            StudentUniversity sv2 = new StudentUniversity("Lâm", 1957, 4, 5, 6, 8);
            sv2.Display();
            Console.WriteLine("Average of score: {0}", sv2.Average());
        }
    }
}
