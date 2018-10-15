using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Models
{
    public class Lop
    {
        [Key]
        public string MaLop { get; set; }
        [Required]
        public string TenLop { get; set; } 
        public virtual ICollection<HocSinh> SinhViens { get; set; }
    }
}