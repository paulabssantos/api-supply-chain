public class ReadPurchaseOrderDto
{    public int Id { get; set; }
    public int Status { get; set; }
    public string? Justification { get; set; }
    public virtual List<ReadValueAnalisysDto> ValueAnalisys { get; set; }

}