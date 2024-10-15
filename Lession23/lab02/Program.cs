namespace lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //khai báo các biến
            string id, name;
            double mark1, mark2, mark3, average;
            DateTime birthday;
            //nhập dữ liệu từ bàn phím
            Console.Write("nhập mã số:");
            id = Console.ReadLine();
            Console.Write("nhập tên:");
            name = Console.ReadLine();
            Console.Write("nhập ngày sinh:");
            birthday = Convert.ToDateTime(Console.ReadLine());
            Console.Write("nhập điểm môn 1:");
            mark1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhập điểm môn 2:");
            mark2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhập điểm môn 3:");
            mark3 = Convert.ToDouble(Console.ReadLine());
            //tính điểm trung bình
            average = (mark1 + mark2 + mark3) / 3;
            //in thông tin ra màn hình
            Console.WriteLine("\n thông tin sinh viên");
            Console.WriteLine("mã số:{0}", id);
            Console.WriteLine("họ và tên:{0}", name);
            Console.WriteLine("ngày sinh:{0:dd/MM/yyyy}",birthday);
            Console.WriteLine("điểm 1:{0:N}, điểm 2:{1:N}, điểm 3:{2:N}",mark1,mark2,mark3);
            Console.WriteLine("điểm trung bình:{0:N}",average);
        }
    }
}
