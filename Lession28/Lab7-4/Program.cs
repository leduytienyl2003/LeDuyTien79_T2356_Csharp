using System.Security.Cryptography.X509Certificates;

namespace Lab7_4
{
    public class InvalidInputNumber : Exception
    {
        public InvalidInputNumber()
            :base("Hãu nhập 1 số > 0") {}
         
    class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding=System.Text.Encoding.UTF8;
                int intCnt;
                int intNum = 0;
                Console.Write("nhập 1 số:");
                //nhập và tung ngoại lệ
                try
                {
                    intNum = Convert.ToInt32(Console.ReadLine());
                    if (intNum <= 0)
                    {
                        throw new InvalidInputNumber();
                    }
                }
                catch(InvalidInputNumber objInlidInput)
                {
                    Console.WriteLine(objInlidInput.Message);
                }
                catch(System.FormatException objFormatException)
                {
                    Console.WriteLine(objFormatException.Message);
                }
                finally
                {
                    if (intNum > 0)
                    {
                        //in ra dãy số *100
                        for (intCnt = 1; intCnt <= 10; intCnt++)
                            Console.WriteLine(intCnt * intNum);
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
