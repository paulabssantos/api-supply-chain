
public class PurchaseOrderRepository : IPurchaseOrderRepository
{
    private MySqlContext _context;

    public PurchaseOrderRepository(MySqlContext context)
    {
        _context = context;
    }

    public PurchaseOrder Create(PurchaseOrder data)
    {
        _context.PurchaseOrder.Add(data);
        _context.SaveChanges();
        return data;
    }
}