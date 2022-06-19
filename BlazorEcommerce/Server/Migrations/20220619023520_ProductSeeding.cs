using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "《深入理解计算机系统》是2016年机械工业出版社的图书，作者是（美）布赖恩特（Bryant,R.E.）。", "https://pic2.zhimg.com/50/v2-0e7703feee9982f5e895adf7320ef62a_qhd.jpg", 9.99m, "深入理解计算机系统" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "《算法导论》是2013年机械工业出版社出版的图书，作者是（美）科曼（Cormen,T.H.）。", "https://www.manongbook.com/d/file/other/349d084f02704a96271ed438091a98f3.jpg", 8.99m, "算法导论" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "深入理解C#(第2版)》是C#领域不可多得的经典著作。作者在详尽地展示C#各个知识点的同时，更注重从现象中挖掘本质。本书深入探索了C#的核心概念和经典特性，并将这些特性融入到代码中，让读者能够真正领会到C#之“深入”与“精妙”。在第1版的基础上，书中新增了C# 4的新特性，如动态类型、命名实参和可选参数等，这些特性将C#语言提升到了一个新的层次。 《深入理解C#(第2版)》适合中高级.NET开发人员阅读。", "https://img10.360buyimg.com/n1/g13/M05/09/17/rBEhUlNfE4cIAAAAAAUcCj-MfJEAAMnOwImCHMABRwi614.jpg", 6.99m, "深入理解C#" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
