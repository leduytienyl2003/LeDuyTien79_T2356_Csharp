namespace lab3_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            Employee e=new Employee();
            e.Id = 1;
            e.Name = "Lê Duy Tiến";
            e.salaryLevel = 50;
            e.basicSalary = 300;
            e.Display();
            double Income = e.GetInCome();
            Console.WriteLine("Thu nhập:{0}",Income);
            Console.ReadKey();
        }
    }
}
