public class QuotationFileRepository : IQuotationFileRepository
{
    private MySqlContext _context;

    public QuotationFileRepository(MySqlContext context){
        _context = context;
    }
    public void Create(QuotationFile data)
    {
        _context.QuotationFile.Add(data);
        _context.SaveChanges();
    }
}