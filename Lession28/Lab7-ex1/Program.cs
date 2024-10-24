namespace DongVat
{
     class Program
    {
        static void Main(string[] args)
        {
            Bo bo=new Bo(1,"bò",500);
            Trau trau = new Trau(2, "trâu", 600);
            De de = new De(3, "dê", 400);

            CaSau casau = new CaSau(4, "cá sấu", 300);
            Ho ho = new Ho(5, "hổ", 700);
            SuTu sutu = new SuTu(6, "sư tử", 1000);
            //sử dụng phương thức để hiển thị thông tin
            Console.WriteLine(bo.GetInfo());
            Console.WriteLine(trau.GetInfo());
            Console.WriteLine(de.GetInfo());
            Console.WriteLine(casau.GetInfo());
            Console.WriteLine(ho.GetInfo());
            Console.WriteLine(sutu.GetInfo());
        }
    }
}
