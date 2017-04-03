namespace BookSaleWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Products(Title, Author, ISBN,Price) VALUES ('Alphabets', 'Katie Fforde', '9783161484100','8.99')");
            Sql("INSERT INTO Products(Title, Author, ISBN,Price) VALUES ('Dictionary', 'Jane Smith', '9783171484100', '9.99')");
            Sql("INSERT INTO Products(Title, Author, ISBN,Price) VALUES ('Numbers', 'Richard Harrison', '9783161884100', '10.99')");
            Sql("INSERT INTO Products(Title, Author, ISBN,Price) VALUES ('Poem', 'John Green', '9783191484100', '11.99')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Products WHERE Title = 'Alphabets' AND Author = 'Katie Fforde' AND ISBN = '9783161484100' AND Price = '8.99' ");
            Sql("DELETE FROM Products WHERE Title = 'Dictionary' AND Author = 'Jane Smith' AND ISBN = '9783171484100' AND Price = '9.99' ");
            Sql("DELETE FROM Products WHERE Title = 'Numbers' AND Author = 'Richard Harrison'AND ISBN = '9783181484100' AND Price = '10.99'");
            Sql("DELETE FROM Products WHERE Title = 'Poem' AND Author = 'John Green' AND ISBN = '9783161984100' AND Price = '11.99'");
        }
    }
}
