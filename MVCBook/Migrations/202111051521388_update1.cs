namespace MVCBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Books", newName: "Book");
            AlterColumn("dbo.Book", "Name", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Book", "Author", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Book", "PublicationDate", c => c.String(maxLength: 8000, unicode: false));
            AlterColumn("dbo.Book", "Content", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Book", "Price", c => c.Decimal(nullable: false, storeType: "money"));
            AlterColumn("dbo.Book", "PriceConfirm", c => c.Decimal(nullable: false, storeType: "money"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Book", "PriceConfirm", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Book", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Book", "Content", c => c.String());
            AlterColumn("dbo.Book", "PublicationDate", c => c.String());
            AlterColumn("dbo.Book", "Author", c => c.String());
            AlterColumn("dbo.Book", "Name", c => c.String());
            RenameTable(name: "dbo.Book", newName: "Books");
        }
    }
}
