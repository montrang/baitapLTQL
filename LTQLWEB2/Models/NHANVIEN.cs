using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQLWEB2.Models
{
    public class NHANVIEN
    {
        [Key]
        public string MaNV { get; set; }
        [Required, MaxLength(20)]
        public string TenNV { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}