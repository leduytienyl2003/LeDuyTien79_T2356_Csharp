namespace Lab7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo mới đối tượng House tring namespace Business
            //bạn có thể using ở trên đầu tệp tin vieets ngắn gọn hơn
            Business.House h=new Business.House();
            //gán gtri
            h.HouseNo = "SD342fd";
            h.Price = 3242343;
            //in thông tin
            Console.WriteLine("House Detail");
            Console.WriteLine("\t House No:"+h.HouseNo);
            Console.WriteLine("\t Price:"+h.Price);
            //tạo mới đối tượng car trong namwspace Business.Dealership
            //bnj có thể using ở trên đầu tệp tin để viết ngắn gọn hơn
            Business.Dealership.Car c = new Business.Dealership.Car();
            c.CarNo = "ad990";
            c.Price = 32435.45M;
            //in thoong tin
            Console.WriteLine("Car detail");
            Console.WriteLine("\t Car No:" + h.HouseNo);
            Console.WriteLine("\t Price:" + h.Price);
        }
    }
}
