namespace super.web.market.dal
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class DataContext : DbContext
    {
        // Your context has been configured to use a 'DataModel' connection string from your application's
        // configuration file (App.config or Web.config). By default, this connection string targets the
        // 'super.web.market.dal.DataModel' database on your LocalDb instance.
        //
        // If you wish to target a different database and/or database provider, modify the 'DataModel'
        // connection string in the application configuration file.
        public DataContext()
            : base("name=DataModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<ItemCategory> ItemsCategories { get; set; }
        public DbSet<ItemTax> ItemsTaxes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Country>().ToTable("Countries");
            modelBuilder.Entity<Province>().ToTable("Provinces");
            modelBuilder.Entity<City>().ToTable("Cities");
            modelBuilder.Entity<Item>().ToTable("Items");
            modelBuilder.Entity<Tax>().ToTable("Taxes");
            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<Photo>().ToTable("Photos");
            modelBuilder.Entity<ItemCategory>().ToTable("ItemsCategories");
            modelBuilder.Entity<ItemTax>().ToTable("ItemsTaxes");
        }
    }
}