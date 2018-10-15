using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication1.Models
{
    public class HocSinh
    {
        [Key]
        public string MaHS { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public virtual Lop Lop { get; set; }
    }
}