using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLWEB2.Models
{
    public class SANPHAM
    {
        [Key]
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string NHOMSP_MaNhomSP { get; set; }
        [ForeignKey("NHOMSP_MaNhomSP")]
        public NHOMSP NHOMSP { get; set; }
        public string SoLuong { get; set; }
        public string DVT { get; set; }
        public string Anh { get; set; }
        public string DonGiaNhap { get; set; }
        public string DonGiaBan { get; set; }
        public string HSD { get; set; }
        public string GhiChu { get; set; }
        public virtual ICollection<CHITIETHD> CHITIETHDs { get; set; }

    }
}