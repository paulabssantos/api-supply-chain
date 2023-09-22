using System.ComponentModel.DataAnnotations;

public interface CreateValueAnalysisDto
{
    [Required(ErrorMessage = "Id da solicitação de análise do produto é obrigatório")]
    public int ProductAnalisysValueRequestId { get; set; }

    [Required(ErrorMessage = "Id do fornecedor é obrigatório")]
    public int SupplierId { get; set; }

    [Required(ErrorMessage = "Id da cotação é obrigatório")]
    public int QuotationId { get; set; }
    
    [Required(ErrorMessage = "Preço do produto é obrigatório")]
    public float Price { get; set; }
}