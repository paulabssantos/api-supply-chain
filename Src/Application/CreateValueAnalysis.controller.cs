using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("valueAnalisys")]
[Tags("ValueAnalysis")]
public class CreateValueAnalisysController : ControllerBase{
    private readonly CreateValueAnalisysService _createValueAnalisysService;
    public CreateValueAnalisysController(CreateValueAnalisysService createValueAnalisysService){
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