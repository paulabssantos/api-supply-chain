using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/purchaseOrder")]
public class CreatePurchaseOrderController: ControllerBase{

    private readonly CreatePurchaseOrderService _createPurchaseOrderService;

    public CreatePurchaseOrderController(CreatePurchaseOrderService createPurchaseOrderService){
        _createPurchaseOrderService = createPurchaseOrderService;
    }

[HttpPost]
public IActionResult Handle(CreatePurchaseOrderDto data){
    var (error, purchaseOrder) = _createPurchaseOrderService.Execute(data);

    if(error != null){
        return StatusCode(error.statusCode,error);
    }
    return Ok(purchaseOrder);
}
}