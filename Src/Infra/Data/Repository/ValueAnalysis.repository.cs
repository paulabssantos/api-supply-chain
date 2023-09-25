
public class ValueAnalysisRepository : IValueAnalisysRepository
{
    private MySqlContext _context;

    public ValueAnalysisRepository(MySqlContext context)
    {
        _context = context;
    }

    public List<ValueAnalisys> Create(List<ValueAnalisys> data)
    {
        _context.ValueAnalisys.AddRange(data);
        _context.SaveChanges();
        return data;

    }

    public void UpdatePurchaseOrder(int id, int purchaseOrderId)
    {
        var valueAnalisysToUpdate = _context.ValueAnalisys.FirstOrDefault(valueAnalisys => valueAnalisys.Id == id);
        if (valueAnalisysToUpdate != null)
        {
            valueAnalisysToUpdate.PurchaseOrderId = purchaseOrderId;
            _context.ValueAnalisys.Update(valueAnalisysToUpdate);
            _context.SaveChanges();
        }
    }
}