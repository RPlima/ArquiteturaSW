namespace ArquiteturaSW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estilo",
                c => new
                    {
                        IdEstilo = c.Int(nullable: false, identity: true),
                        NomeEstilo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdEstilo);
            
            CreateTable(
                "dbo.Movel",
                c => new
                    {
                        IdMovel = c.Int(nullable: false, identity: true),
                        NomeMovel = c.String(nullable: false),
                        Imagem = c.String(),
                        IdEstilo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdMovel)
                .ForeignKey("dbo.Estilo", t => t.IdEstilo, cascadeDelete: true)
                .Index(t => t.IdEstilo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movel", "IdEstilo", "dbo.Estilo");
            DropIndex("dbo.Movel", new[] { "IdEstilo" });
            DropTable("dbo.Movel");
            DropTable("dbo.Estilo");
        }
    }
}
