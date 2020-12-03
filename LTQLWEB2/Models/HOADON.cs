using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLWEB2.Models
{
    public class HOADON
    {
        [Key]
        public string MaHD { get; set; }
        public string NHANVIEN_MaNV { get; set; }
        [ForeignKey("NHANVIEN_MaNV")]
        public NHANVIEN NHANVIEN { get; set; }
        public string NgayBan { get; set; }
        public string KHACHHANG_MaKH { get; set; }
        [ForeignKey("KHACHHANG_MaKH")]
        public KHACHHANG KHACHHANG { get; set; }
        public string TongTien { get; set; }
        public virtual ICollection<CHITIETHD> CHITIETHDs { get; set; }
    }
}