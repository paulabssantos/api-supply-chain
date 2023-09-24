public class ReadProductAnalysisValueRequestDto
{
    public int Id {get;set;}

    public ReadProductDto Product { get; set; }

    public int QuotationId {get;set;}

    public int Quantity { get; set; }

}