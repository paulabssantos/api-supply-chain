using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/quotationFile")]
[Tags("QuotationFile")]
public class CreateQuotationFileController : ControllerBase
{

    private readonly CreateQuotationFileService _createQuotationFileService;

    public CreateQuotationFileController(CreateQuotationFileService createQuotationFileService)
    {
        _createQuotationFileService = createQuotationFileService;
    }

    [HttpPost("{quotationId}")]
    public IActionResult Handle([FromForm] List<IFormFile> files, int quotationId)
    {
        _createQuotationFileService.Execute(files, quotationId);
        return Ok();
    }
}