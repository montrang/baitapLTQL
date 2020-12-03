using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLWEB2.Models
{
    public class KHACHHANG
    {
        [Key]
        public string MaKH { get; set; }
        [Required, MaxLength(20)]
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PassWord { get; set; }
        [NotMapped]
        [Required]
        [System.ComponentModel.DataAnnotations.Compare("PassWord")]
        public string confirm_password { get; set; }
        public virtual ICollection<HOADON> HOADONs { get; set; }

    }
}