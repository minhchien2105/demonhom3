using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class QuanLiSinhVien:DbContext
    {
        public QuanLiSinhVien():base("QLSinhVien")
        { }
        public DbSet<HocSinh> HocSinhs { get; set; }
        public DbSet<Lop> Lops { get; set; }
    }
}