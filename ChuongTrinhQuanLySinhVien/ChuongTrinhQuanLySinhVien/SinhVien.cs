using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhQuanLySinhVien
{
    internal class SinhVien
    {
        public int Ma { set; get; }
        public string HoTen { set; get; }
        public DateTime NgaySinh { set; get; }
        public override string ToString()
        {
            return Ma+" "+HoTen+" "+NgaySinh.ToShortDateString().ToString();
        }

    }
}
