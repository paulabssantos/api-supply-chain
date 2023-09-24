using System.ComponentModel.DataAnnotations;

public class QuotationFile
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Id da cotação é obrigatório")]
    public int QuotationId { get; set; }
    public virtual Quotation Quotation { get; set; }

    [Required(ErrorMessage = "Caminho do arquivo da cotação é obrigatório")]
    public string FilePath { get; set; }
}