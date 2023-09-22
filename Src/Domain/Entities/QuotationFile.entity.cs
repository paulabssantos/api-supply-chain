using System.ComponentModel.DataAnnotations;

public class QuotationFile
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Id da cotação é obrigatório")]
    public int QuotationId { get; set; }
    public virtual Quotation Quotation { get; set; }

    [Required(ErrorMessage = "Id do fornecedor é obrigatório")]

    public int SupplierId { get; set; }
    public virtual Supplier Supplier { get; set; }

    [Required(ErrorMessage = "Caminho do arquivo da cotação é obrigatório")]
    public string FilePath { get; set; }
}