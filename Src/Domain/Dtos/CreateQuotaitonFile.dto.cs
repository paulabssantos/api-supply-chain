using System.ComponentModel.DataAnnotations;

public class CreateQuotationFileDto
{

    [Required(ErrorMessage = "Id da cotação é obrigatório")]
    public int QuotationId { get; set; }

    [Required(ErrorMessage = "Caminho do arquivo da cotação é obrigatório")]
    public string FilePath { get; set; }
}