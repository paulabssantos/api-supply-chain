using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("quotation")]
[Tags("Quotation")]
public class FindQuotationController : ControllerBase{
    private readonly FindQuotationService _findQuotationService;
    public FindQuotationController(FindQuotationService findQuotationService){
        _findQuotationService = findQuotationService;
    }  
    
    [HttpGet("{id}")]
    public IActionResult Handle(int id){
        var (error,quotation) = _findQuotationService.Execute(id);
          if (error != null)
        {
            return StatusCode(error.statusCode, error);
        }
        return Ok(quotation);
    }
}