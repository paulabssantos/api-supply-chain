using System.ComponentModel.DataAnnotations;

public class CreateValueAnalysisDto
{
    [Required(ErrorMessage = "Id da solicitação de análise do produto é obrigatório")]
    public int ProductAnalisysValueRequestId { get; set; }

    [Required(ErrorMessage = "Id do fornecedor é obrigatório")]
    public int SupplierId { get; set; }
    
    [Required(ErrorMessage = "Preço do produto é obrigatório")]
    public float Price { get; set; }
}