using System.ComponentModel.DataAnnotations;

public class CreateQuotationDto
{

    [Required(ErrorMessage = "Descrição da cotação é obrigatório")]

    public string Description { get; set; }

    [Required(ErrorMessage = "Tipo da cotação é obrigatório")]

    public string Type { get; set; }
    public virtual List<ProductAnalisysValueRequest> ProductAnalisysValueRequests { get; set; }
}