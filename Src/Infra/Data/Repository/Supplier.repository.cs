
public class SupplierRepository : ISupplierRepository
{
    private MySqlContext _context;

    public SupplierRepository(MySqlContext context)
    {
        _context = context;
    }
    public List<Supplier> List()
    {
        return _context.Supplier.ToList();
    }
}