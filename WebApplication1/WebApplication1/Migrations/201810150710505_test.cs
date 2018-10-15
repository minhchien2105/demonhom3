namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HocSinhs",
                c => new
                    {
                        MaHS = c.String(nullable: false, maxLength: 128),
                        HoTen = c.String(),
                        GioiTinh = c.Boolean(nullable: false),
                        Lop_MaLop = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaHS)
                .ForeignKey("dbo.Lops", t => t.Lop_MaLop)
                .Index(t => t.Lop_MaLop);
            
            CreateTable(
                "dbo.Lops",
                c => new
                    {
                        MaLop = c.String(nullable: false, maxLength: 128),
                        TenLop = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MaLop);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HocSinhs", "Lop_MaLop", "dbo.Lops");
            DropIndex("dbo.HocSinhs", new[] { "Lop_MaLop" });
            DropTable("dbo.Lops");
            DropTable("dbo.HocSinhs");
        }
    }
}
