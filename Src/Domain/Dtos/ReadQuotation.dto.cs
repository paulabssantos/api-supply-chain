public class ReadQuotationDto
{
    public int Id { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public virtual List<ReadProductAnalysisValueRequestDto> ProductAnalisysValueRequests { get; set; }
}