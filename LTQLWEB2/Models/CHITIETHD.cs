using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLWEB2.Models
{
    public class CHITIETHD
    {
        [Key]
        public int ID { get; set; }
        public string HOADON_MaHD { get; set; }
        [ForeignKey("HOADON_MaHD")]
        public HOADON HOADON { get; set; }
        public string SANPHAM_MaSP { get; set; }
        [ForeignKey("SANPHAM_MaSP")]
        public SANPHAM SANPHAM { get; set; }
        public string SoLuong { get; set; }
        public string DonGia { get; set; }
        public string GiamGia { get; set; }
        public string ThanhTien { get; set; }
    }
}