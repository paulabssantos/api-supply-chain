using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("valueAnalysis")]
[Tags("ValueAnalysis")]
public class CreateValueAnalisysController : ControllerBase{
    private readonly CreateValueAnalysisService _createValueAnalisysService;
    public CreateValueAnalisysController(CreateValueAnalysisService createValueAnalisysService){
        _createValueAnalisysService = createValueAnalisysService;
    }  
    
    [HttpPost]
    public IActionResult Handle(List<CreateValueAnalysisDto> data){
        var (error,valueAnalisys) = _createValueAnalisysService.Execute(data);
          if (error != null)
        {
            return StatusCode(error.statusCode, error);
        }
        return Ok(valueAnalisys);
    } 
}