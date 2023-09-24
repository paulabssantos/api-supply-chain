using Microsoft.EntityFrameworkCore;

public class MySqlContext : DbContext
{
    public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

    public DbSet<Product> Product { get; set; }
    public DbSet<Supplier> Supplier { get; set; }
    public DbSet<Quotation> Quotation { get; set; }
    public DbSet<ProductAnalisysValueRequest> ProductAnalisysValueRequest { get; set; }
    public DbSet<QuotationFile> QuotationFile { get; set; }
    public DbSet<ValueAnalisys> ValueAnalisys { get; set; }
    public DbSet<PurchaseOrder> PurchaseOrder { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductAnalisysValueRequest>().HasOne(productAnalisysValueRequest => productAnalisysValueRequest.Product).WithMany(product => product.ProductAnalisysValueRequests).HasForeignKey(productAnalisysValueRequest => productAnalisysValueRequest.ProductId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<ProductAnalisysValueRequest>().HasOne(productAnalisysValueRequest => productAnalisysValueRequest.Quotation).WithMany(quotation => quotation.ProductAnalisysValueRequests).HasForeignKey(productAnalisysValueRequest => productAnalisysValueRequest.QuotationId).OnDelete(DeleteBehavior.Cascade);
        modelBuilder.Entity<QuotationFile>().HasOne(quotationFile => quotationFile.Quotation).WithMany(quotation => quotation.QuotationFile).HasForeignKey(quotationFile => quotationFile.QuotationId);
        modelBuilder.Entity<ValueAnalisys>().HasOne(valueAnalisys => valueAnalisys.ProductAnalisysValueRequest).WithMany(productAnalisysValueRequest => productAnalisysValueRequest.ValueAnalisys).HasForeignKey(valueAnalisys => valueAnalisys.ProductAnalisysValueRequestId);
        modelBuilder.Entity<ValueAnalisys>().HasOne(valueAnalisys => valueAnalisys.Supplier).WithMany(supplier => supplier.ValueAnalisys).HasForeignKey(valueAnalisys => valueAnalisys.SupplierId);
        modelBuilder.Entity<ValueAnalisys>().HasOne(valueAnalisys => valueAnalisys.PurchaseOrder).WithMany(purchaseOrder => purchaseOrder.ValueAnalisys).HasForeignKey(purchaseOrder => purchaseOrder.PurchaseOrderId).IsRequired(false);
    }
}