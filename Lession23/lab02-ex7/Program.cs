namespace lab02_ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soDong = 10;//thay đổi số dòng nếu muốn
            for (int i = 1; i <= soDong; i++)
            {
                Console.Write(new string(' ', (soDong - i)));
                int num = i;
                //in số tăng dần
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num % 10);
                    num++;
                }
                num -= 2;
                //in số giảm dần
                for (int j = 1; j < i; j++)
                {
                    Console.Write(num % 10);
                    num--;
                }
                Console.WriteLine();//xuống dòng
            }
        }
    }
}
