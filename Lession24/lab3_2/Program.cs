namespace lab3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            //tạo đối tượng contact với constructor không tham số
            Contact ct1 = new Contact();
            //gán giá trị cho ct1
            ct1.Id = 6;
            ct1.Firstname = "Lê Duy";
            ct1.Lastname = "Tiến";
            ct1.Address = "Hà Nội";
            ct1.Phone = "0981705963";
            ct1.Email = "leduytien2003yl@gmail.com";
            //tạo đối tượng contact với constructor có tham số
            Contact ct2 = new Contact(5, "Tô", "Lâm", "Hưng Yên", "0989999999", "Congangmail.com");
            //hiển thị thoong tin ct1 và ct2
            ct1.Display();
            ct2.Display();
        }
    }
}
