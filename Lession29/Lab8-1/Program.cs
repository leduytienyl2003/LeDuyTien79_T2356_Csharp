namespace Lab8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khởi tạo tập dữ liệu
            string[] data = { "to", "ve", "hon"," nguoi", "thi", "nguoi", "se", "tro", "thanh", "ke", "thu", "cua", "ta" };
            //truy vấn dữ liệu
            IEnumerable<string> result1=from m in data select m;
            //hiển thị kết quả
            Console.WriteLine("hiển thị tất cả kết quả");
            foreach(var item in result1)
            {
                Console.Write(item+" ");
            }
            //truy vấn theo điều kiện lấy các từ là "nguoi"
            IEnumerable<string> result2=from m in data where m.Equals("nguoi")
            select m;
            //hiển thị kết quả
            Console.WriteLine("\nTruy vấn theo điều kiện");
            foreach(var item in result2)
            {
                Console.WriteLine(item + " ");
            }
            //sắp xếp dữ liệu
            IEnumerable<string> result3=from m in data orderby m select m;
            //hiển thị kết quả
            Console.WriteLine("hiển thị tất cả kết quả sắp xếp");
            foreach(var item in result3)
            {
                Console.Write(item + " ");
            }
            //lấy dữ liệu mới
            var result4 = from m in data select new { Thuong = m.ToLower(), Hoa = m.ToUpper() };
            //hiển thị kết quả
            Console.WriteLine("chu thuong va hoa");
            foreach(var item in result4)
            {
                Console.WriteLine(item.Thuong + ":" + item.Hoa);
            }
        }
    }
}
