namespace Lab8_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khai báo chung
            int[] Numbers = { 7, 9, 3, 5, 2, 1, 0, 6, 4, 3, 1 };
            string[] Words =
            {
                "Chỉ","trích","phê","phán","người","khác","giống","như","con","chim","bồ","câu","đưa","thư","bao","giờ","cũng","quay","về","nơi","sản","xuất","phát" };
            List<Film> ListFilm = new List<Film>()
            {
                new Film {FilmId="F01",FilmName="Điệp viên 007",Price=120000},
                new Film {FilmId="F02",FilmName="Tam quốc diễn nghĩa",Price=130000},
                new Film {FilmId="F03",FilmName="Thiếu lâm truyền kỳ",Price=100000},
                new Film {FilmId="F04",FilmName="Người nhện 2",Price=160000},
                new Film {FilmId="F05",FilmName="Ngân hàng tình yêu",Price=340000},
                new Film {FilmId="F06",FilmName="Người đẹp và quái thú",Price=230000},
                new Film {FilmId="F07",FilmName="Biệt động sài gòn",Price=190000},
            };
            //lọc các số chẵn 
            IEnumerable<int> querynumber = Numbers.Where(n => n % 2 == 0);
            Show<int>(querynumber, "Lọc các số chẵn:");
            //lọc các từ có độ dài >4
            IEnumerable<string> queryword = Words.Where(w => w.Length > 4);
            Show<string>(queryword, "Lọc các từ có độ dài >4:");
            //lọc các từ có tên bắt đầu bằng chữ t
            IEnumerable<string> queryT = Words.Where(w => w.StartsWith("t"));
            Show<string>(queryT, "Lọc các từ có chữ đầu bằng t:");
            //lọc các số duy nhất trong tập các số
            var uniqueNumber = Numbers.Distinct();
            Show<int>(uniqueNumber, "lọc các số duy nhất trong tập các số:");
            //đếm xem có bnh từ không trùng nhau
            var countDistinct =Words.Distinct().Count();
            Console.WriteLine("đếm xem có bnh từ không trùng nhau:" + countDistinct);
            //lấy 4 số đầu tiên trong dãy
            var fourNumber = Numbers.Take(4);
            Show<int>(fourNumber, "lấy 4 số đầu tiên trong dãy:");
            //lấy 2 từ đầu tiên trong câu
            var twoword =Words.Take(2);
            Show<string>(twoword, "lấy 2 từ đầu tiên trong câu:");
            //lấy những từ đầu tiên có chứa chữ t
            var searchword = Words.TakeWhile(w=>w.Contains('t'));
            Show<string>(searchword, "lấy những từ đầu tiên có chứa chữ t:");
            //sắp xếp theo đơn giá, lấy những phim đầu tiên có đơn giá <200000
            var queryfilm=ListFilm.OrderBy(f=>f.Price)
                .Select(x=>new {x.FilmId, x.FilmName,x.Price})
                .ToList().TakeWhile(t=>t.Price<200000);
            //bỏ qua 3 phần tử đầu tiên, lấy tất cả các phần tử còn lại
            var skipNumber = Numbers.Skip(3);
            Show<int>(skipNumber, "bỏ qua 3 phần tử đầu tiên, lấy tất cả các phần tử còn lại:");
            //bỏ qua 4 phần tử đầu tiên lấy 3 ptu kế tiếp
            var skipTakeNumber=Numbers.Skip(4).Take(3);
            Show<int>(skipNumber, "bỏ qua 4 phần tử đầu tiên lấy 3 ptu kế tiếp:");
            //bỏ qua 3 phim đầu tiên lấy 3 phim kế tiếp
            var skipTakeFilm=ListFilm.Skip(3).Take(3);
            Show<Film>(skipTakeFilm, "bỏ qua 3 phim đầu tiên lấy 3 phim kế tiếp:");
            //sắp xếp giảm dần, sau đó lấy các phần tử <5
            var sortNumber = Numbers.OrderByDescending(x => x).SkipWhile(x => x > 5);
            Show<int>(sortNumber, "sắp xếp giảm dần, sau đó lấy các phần tử <5:");

        }
        static void Show<T>(IEnumerable<T> data, string message)
        {
            Console.WriteLine(message);
            foreach(var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
