using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAmazingMicroservice.Migrations
{
    public partial class AddBlogTableData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(table: "Blogs",
                columns: new[] { "BlogId", "Url" },
                values: new object[] { 1, "https://www.helpscout.net/blog/" });
            migrationBuilder.InsertData(table: "Blogs",
                columns: new[] { "BlogId", "Url" },
                values: new object[] { 2, "https://www.digital-photography-school.com/" });
            migrationBuilder.InsertData(table: "Blogs",
                columns: new[] { "BlogId", "Url" },
                values: new object[] { 3, "http://freshome.com/" });
            migrationBuilder.InsertData(table: "Blogs",
                columns: new[] { "BlogId", "Url" },
                values: new object[] { 4, "http://www.spring.org.uk/" });
            migrationBuilder.InsertData(table: "Blogs",
                columns: new[] { "BlogId", "Url" },
                values: new object[] { 5, "https://nerdfitness.com/blog/" });
            migrationBuilder.InsertData(table: "Blogs",
                columns: new[] { "BlogId", "Url" },
                values: new object[] { 6, "https://1stwebdesigner.com/" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 1);
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 2);
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 3);
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 4);
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 5);
            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: 6);
        }
    }
}
