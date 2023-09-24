using System.ComponentModel.DataAnnotations;

public class Supplier{

    [Key]
    public int Id {get;set;}
    [Required(ErrorMessage = "Nome do fornecedor é obrigatório")]
    public string Name{get;set;}

    public virtual List<ValueAnalisys> ValueAnalisys {get;set;}
}