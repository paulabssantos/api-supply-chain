using System.ComponentModel.DataAnnotations;

public interface CreateQuotationFileDto
{

    [Required(ErrorMessage = "Id da cotação é obrigatório")]
    public int QuotationId { get; set; }
    [Required(ErrorMessage = "Id do fornecedor é obrigatório")]
    public int SupplierId { get; set; }

    [Required(ErrorMessage = "Caminho do arquivo da cotação é obrigatório")]
    public string FilePath { get; set; }
}