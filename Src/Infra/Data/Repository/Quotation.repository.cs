public class QuotationRepository : IQuotationRepository
{
    private MySqlContext _context;

    public QuotationRepository(MySqlContext context){
        _context = context;
    }
    public Quotation Find(int Id)
    {
        return _context.Quotation.FirstOrDefault(quotation => quotation.Id == Id);
    }
}