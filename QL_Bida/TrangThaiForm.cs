using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QL_Bida
{
    public class TrangThaiForm
    {

        public bool khachLe { get; set; }
        public string LoaiBan { get; set; }
        public string maKhachHang { get; set; }
        public string startTime { get; set; }
        public string ngayChoi { get; set; }
        public string loaiKhach { get; set; }
        public string giamGia { get; set; }
        public string giaGioChoi { get; set; }
        public string phiDV { get; set; }
        public DataTable dsDV_Ordered { get; set; }
        public TrangThaiForm()
        {

        }
    }
}
