using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("supplier")]
[Tags("Supplier")]
public class ListSuppliersController : ControllerBase{
    private readonly ListSuppliersService _listSuppliersService;
    public ListSuppliersController(ListSuppliersService listSuppliersService){
        _listSuppliersService = listSuppliersService;
    }
     
     [HttpGet]
    public IActionResult Handle(){
        var (error,suppliers) = _listSuppliersService.Execute();

        if(error != null){
            return StatusCode(error.statusCode,error);
        }

        return Ok(suppliers);
    }
}