namespace Lab7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            //khai báo mảng
            byte[] a = new byte[5];
            //nhập mảng
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.Write("a[{0}]=", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch(FormatException ex) 
            {
                //console.writeLine(ex.Message);
                Console.WriteLine("Không đưuọc nhập kí tự cho mảng số");
            }
            catch(OverflowException ex)
            {
                //console.writeLine(ex.Message);
                Console.WriteLine("Khoong được nhập giá trị nằm ngoài miền 0-255");
            }
            catch (IndexOutOfRangeException)
            {
                //console.writeLine(ex.Message);
                Console.WriteLine("Lỗi vượt quá phạm vi của mảng");
            }
            Console.WriteLine("Nội dung mảng");
            for(int i = 0; i < 5; i++)
            {
                Console.Write(" {0}", a[i]);
            }
        }
    }
}
