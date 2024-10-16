
namespace lab3_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            book b1 = new book();
            book b2 = new book("Lê Duy Tiến",15,"VN","CHA GIÀU CHA NGHÈO","50");
            b1.Display();
            b2.Display();

            b1.flipPageForWard();
            b1.flipPageBackWard();
            Console.ReadKey();
        }
    }
}
