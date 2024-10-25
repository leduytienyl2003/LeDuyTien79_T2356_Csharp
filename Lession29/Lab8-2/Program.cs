using System.Xml.Linq;

namespace Lab8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khởi tạo customer
            var customers = new Customer[]
            {
            new Customer{ ID = 5,Name = "Tien"},
            new Customer{ ID = 6,Name = "Lam"},
            new Customer{ ID = 7,Name = "Chinh"},
            new Customer{ ID = 8,Name = "Hue"}
        };
            //khởi tạo order
            var orders = new Order[]
            {
            new Order{ID=5,Product="Book"},
            new Order{ID=6,Product="Game"},
            new Order{ID=7,Product="Computer"},
            new Order{ID=8,Product="Shirt"}
            };
            //sử dụng truy vấn và join 2 tập dữ liệu dựa trên ID
            var query = from c in customers join o in orders on c.ID equals o.ID select new { c.Name, o.Product };
            //hiển thị tên khách hàng và nhóm sản phẩm
            foreach (var group in query)
            {
                Console.WriteLine("{0} bought {1}", group.Name, group.Product);
            }
        }
    }
}
