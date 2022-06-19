namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "深入理解计算机系统",
                    Description = "《深入理解计算机系统》是2016年机械工业出版社的图书，作者是（美）布赖恩特（Bryant,R.E.）。",
                    ImageUrl = "https://pic2.zhimg.com/50/v2-0e7703feee9982f5e895adf7320ef62a_qhd.jpg",
                    Price = 9.99m
                }, new Product
                {
                    Id = 2,
                    Title = "算法导论",
                    Description = "《算法导论》是2013年机械工业出版社出版的图书，作者是（美）科曼（Cormen,T.H.）。",
                    ImageUrl = "https://www.manongbook.com/d/file/other/349d084f02704a96271ed438091a98f3.jpg",
                    Price = 8.99m
                }, new Product
                {
                    Id = 3,
                    Title = "深入理解C#",
                    Description = "深入理解C#(第2版)》是C#领域不可多得的经典著作。作者在详尽地展示C#各个知识点的同时，更注重从现象中挖掘本质。本书深入探索了C#的核心概念和经典特性，并将这些特性融入到代码中，让读者能够真正领会到C#之“深入”与“精妙”。在第1版的基础上，书中新增了C# 4的新特性，如动态类型、命名实参和可选参数等，这些特性将C#语言提升到了一个新的层次。 《深入理解C#(第2版)》适合中高级.NET开发人员阅读。",
                    ImageUrl = "https://img10.360buyimg.com/n1/g13/M05/09/17/rBEhUlNfE4cIAAAAAAUcCj-MfJEAAMnOwImCHMABRwi614.jpg",
                    Price = 6.99m
                }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
