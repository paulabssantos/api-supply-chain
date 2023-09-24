public class CreatePurchaseOrderService
{
    public (ErrorResponse?, PurchaseOrder?) Execute(CreatePurchaseOrderDto data)
    {
        if((int)data.Status == (int)PurchaseOrderStatusEnum.Repproved || (string.IsNullOrEmpty(data.Justification) || string.IsNullOrWhiteSpace(data.Justification))){
            return(new ErrorResponse("Justificativa não pode ficar vazia quando o status é reprovado"),null);
        }
        PurchaseOrder purchaseOrder = new()
        {
            Id = 1,
            Status = (int)PurchaseOrderStatusEnum.Approved,
            ValueAnalisys = new List<ValueAnalisys>()
            {
                
                new ValueAnalisys { Id = 1, Price = 100, ProductAnalisysValueRequestId = 1, SupplierId = 1 },
            }
        };


        foreach (var valueAnalisys in purchaseOrder.ValueAnalisys)
        {
            valueAnalisys.PurchaseOrderId = purchaseOrder.Id;
        }

        return (null, purchaseOrder);
    }
}
