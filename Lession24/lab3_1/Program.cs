namespace lab3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            // tạo đối tượng car
            Car myCar = new Car();
            //gán gtri cho các trường của đối tượng
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.year = 2003;

            //hiển thị thông tin về đối tượng car
            System.Console.WriteLine("thông tin chi tiết:");
            System.Console.WriteLine("make:" + myCar.make);
            System.Console.WriteLine("model:"+myCar.model);
            System.Console.WriteLine("color:" + myCar.color);
            System.Console.WriteLine("year release: "+myCar.year);
            //gọi các phương thức
            myCar.start();
            myCar.stop();
        }
    }
}
