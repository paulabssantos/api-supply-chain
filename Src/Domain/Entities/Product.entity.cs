using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    public int Id {get;set;}
    
    [Required(ErrorMessage = "Nome do produto é obrigatório")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Descrição do produto é obrigatório")]
    [StringLength(100,ErrorMessage = "Descrição pode ter no máximo 100 caracteres")]

    public string Description { get; set; }

    public virtual List<ProductAnalisysValueRequest> ProductAnalisysValueRequests {get;set;}
}