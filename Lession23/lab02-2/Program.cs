
namespace lab02_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //khai báo biến
            string name;
            int number;
            double money = 0;
            //nhập thông tin
            Console.Write("nhập số thuê bao:");
            name = Console.ReadLine();
            Console.Write("nhập số điện sử dụng:");
            number = Convert.ToInt32(Console.ReadLine());
            //tinhs toán số tiền
            if (number <= 30)
                money = 30;
            else if (number > 30 && number <= 50)
                money = 30 + (number - 30) * 1.2;
            else if (number > 50)
                money = 30 + 20 * 1.2 + (number - 50) * 1.5;
            //in ra thông tin
            Console.WriteLine("\n thông tin tiền điện");
            Console.WriteLine("họ và tên:{0}", name);
            Console.WriteLine("số điện sử dụng:{0}", number);
            Console.WriteLine("số tiền:{0:C}", money);
        }
    }
}
