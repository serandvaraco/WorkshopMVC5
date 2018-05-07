namespace EntityFrameworkClassroomCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Restricciondecampos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "Comment", c => c.String(nullable: false));
            AlterColumn("dbo.Photos", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Photos", "Name", c => c.String());
            AlterColumn("dbo.Comments", "Comment", c => c.String());
        }
    }
}
