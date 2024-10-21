namespace Lab_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            ///khởi tạo đối tượng sinh viên với 3 sinh viên và mỗi sinh viên gồm 2 điểm
            Student st = new Student(3, 2);
            //sử dụng chỉ số để truy cập vào thành phần mảng của lớp
            st[0] = "tiến";
            st[0, 0] = 9;
            st[0, 1] = 6.5;
            st[1] = "Lâm";
            st[1, 0] = 6;
            st[1, 1] = 8;
            st[2] = "Chung";
            st[2, 0] = 4;
            st[2, 1] = 6.5;
            //in fa thông tin
            Console.WriteLine("Thông tin sinh viên");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Họ và tên:" + st[i]);
                Console.Write("Điểm: ");
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(st[i, j] + ",");
                }
                Console.WriteLine();
            }
        }
    }
}
