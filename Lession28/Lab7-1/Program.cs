using Store;
namespace Lab7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            //tạo mới nhà phân phối cung cấp đầy đủ namespace
            Supply.Manufacturer dealer=new Supply.Manufacturer();
            //gán gtri
            dealer.Name = "Coca Cola";
            dealer.Email = "Leduytien2003yl@gmail.com";
            dealer.Phone = "0981705963";
            //in ra thoong tin
            Console.WriteLine("Dealer information");
            Console.WriteLine("\t Name: "+dealer.Name);
            Console.WriteLine("\t Email: "+dealer.Email);
            Console.WriteLine("\t Phone: "+dealer.Phone);
            //tạo mới sản phẩm nằm trong namespace store
            StoreItem si=new StoreItem();
            //gán gtri
            si.ItemNo = 998899;
            si.ItemName = "sinh tố";
            si.Price = 40.00M;
            //in thông tin
            Console.WriteLine("Store Invemtory");
            Console.WriteLine("\t Item #:         ");
            Console.WriteLine(si.ItemNo);
            Console.Write("\t Item Name:   ");
            Console.WriteLine(si.ItemName);
            Console.Write("\t Unit Price: ");
            Console.WriteLine(si.Price);

            Console.Read();
        }
    }
}
