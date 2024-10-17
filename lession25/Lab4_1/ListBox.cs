using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    internal class ListBox:Window
    {
        //tạo lớp listbox kế thừa từ window
        //khai báo trường mới
        private string listBoxContents;
        //phương thức khởi tạo
        public ListBox(int top, int left, string contents):base(top, left)
        {
            listBoxContents = contents;
        }
        //ghi đè phương thức DrawWindow
        public override void DrawWindow()
        {
            base.DrawWindow();//gọi phương thức lớp cơ sở
            Console.WriteLine("writing string to the listbox: {0}", listBoxContents);
        }
    }
}
