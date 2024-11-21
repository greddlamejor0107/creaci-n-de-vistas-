using Microsoft.EntityFrameworkCore;

namespace ETLDaraWarehouse
{

    public class DatawarehouseContext : DbContext
    {
        public DatawarehouseContext(DbContextOptions<DatawarehouseContext> options) : base(options) { }

        public DbSet<DimCustomer> DimCustomers { get; set; }
        public DbSet<DimEmployee> DimEmployees { get; set; }
        public DbSet<DimShipper> DimShippers { get; set; }
        public DbSet<DimCategory> DimCategories { get; set; }
        public DbSet<DimProduct> DimProducts { get; set; }
        public DbSet<DimSupplier> DimSuppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DimSupplier>(entity =>
            {
                entity.HasKey(e => e.IDSupplier);
            });
            modelBuilder.Entity<DimCategory>(entity =>
            {
                entity.HasKey(e => e.IDCategory); // Define la clave primaria
            });
            modelBuilder.Entity<DimCustomer>(entity =>
            {
                entity.HasKey(e => e.IDCustomer); // Define la clave primaria
            });
            modelBuilder.Entity<DimEmployee>(entity =>
            {

                entity.HasKey(e => e.IDEmployee); // Define la clave primaria
            });

            modelBuilder.Entity<DimProduct>(entity =>
            {
                entity.HasKey(e => e.IDProduct); // Define la clave primaria
            });

            modelBuilder.Entity<DimShipper>(entity =>
            {
                entity.HasKey(e => e.IDShipper); // Define la clave primaria
            });

            modelBuilder.Entity<DimEmployee>()
                .HasOne<DimEmployee>()
                .WithMany()
                .HasForeignKey(d => d.ReportsTo)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DimEmployee>()
                .HasOne<Shipper>()
                .WithMany()
                .HasForeignKey(e => e.ReportsTo)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<DimCustomer>().ToTable("DimCustomer", "DWH");
            modelBuilder.Entity<DimEmployee>().ToTable("DimEmployee", "DWH");
            modelBuilder.Entity<DimShipper>().ToTable("DimShipper", "DWH");
            modelBuilder.Entity<DimCategory>().ToTable("DimCategory", "DWH");
            modelBuilder.Entity<DimProduct>().ToTable("DimProduct", "DWH");
            modelBuilder.Entity<DimSupplier>().ToTable("DimSupplier", "DWH");
        }
    }
}
