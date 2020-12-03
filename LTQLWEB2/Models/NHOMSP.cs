using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQLWEB2.Models
{
    public class NHOMSP
    {
        [Key]
        public string MaNhomSP { get; set; }
        [Required, MaxLength(15)]
        public string TenNhomSP { get; set; }
        public virtual ICollection<SANPHAM> SANPHAMs { get; set; }
    }
}