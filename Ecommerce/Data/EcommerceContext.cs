using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class EcommerceContext: DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options): base(options) 
        {

        }
        #region DBSet
        public DbSet<About> Abouts { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoicesDetails { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Tag> Tags { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>().ToTable(nameof(About));
            modelBuilder.Entity<Brand>().ToTable(nameof(Brand));
            modelBuilder.Entity<Config>().ToTable(nameof(Config));
            modelBuilder.Entity<Contact>().ToTable(nameof(Contact));
            modelBuilder.Entity<Customer>().ToTable(nameof(Customer));
            modelBuilder.Entity<FeedBack>().ToTable(nameof(FeedBack));
            modelBuilder.Entity<Invoice>().ToTable(nameof(Invoice));
            modelBuilder.Entity<InvoiceDetail>().ToTable(nameof(InvoiceDetail));
            modelBuilder.Entity<Menu>().ToTable(nameof(Menu));
            modelBuilder.Entity<Order>().ToTable(nameof(Order));
            modelBuilder.Entity<OrderDetail>().ToTable(nameof(OrderDetail));
            modelBuilder.Entity<Post>().ToTable(nameof(Post));
            modelBuilder.Entity<PostCategory>().ToTable(nameof(PostCategory));
            modelBuilder.Entity<PostComment>().ToTable(nameof(PostComment));
            modelBuilder.Entity<PostTag>().ToTable(nameof(PostTag)).HasKey(table => new
            {
                table.TagsId, table.PostsId
            });
            modelBuilder.Entity<Product>().ToTable(nameof(Product));
            modelBuilder.Entity<ProductCategory>().ToTable(nameof(ProductCategory));
            modelBuilder.Entity<ProductComment>().ToTable(nameof(ProductComment));
            modelBuilder.Entity<Slider>().ToTable(nameof(Slider));
            modelBuilder.Entity<Supplier>().ToTable(nameof(Supplier));
            modelBuilder.Entity<Tag>().ToTable(nameof(Tag));
        }
    }
}
