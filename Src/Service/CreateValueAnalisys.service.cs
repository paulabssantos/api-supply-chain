public class CreateValueAnalisysService
{
    public (ErrorResponse?, List<ValueAnalisys>?) Execute(List<CreateValueAnalysisDto> data)
    {
        Quotation quotation = new Quotation { Code = 1, Description = "Cotação de matéria prima", Id = 1 };
        ProductAnalisysValueRequest productAnalisysValueRequest = new ProductAnalisysValueRequest { Id = 1, ProductId = 1, Quantity = 100, QuotationId = 1 };
        ProductAnalisysValueRequest productAnalisysValueRequest2 = new ProductAnalisysValueRequest { Id = 2, ProductId = 1, Quantity = 100, QuotationId = 1 };

        List<ValueAnalisys> valueAnalisysList = new List<ValueAnalisys>();

        foreach (var valueAnalysis in data)
        {
            List<ProductAnalisysValueRequest> productAnalisysValueRequests = new List<ProductAnalisysValueRequest>
            {
                productAnalisysValueRequest,
                productAnalisysValueRequest2
            };

            var foundProductAnalisysValueRequest = productAnalisysValueRequests.Find(productAnalisysValueRequest => productAnalisysValueRequest.Id == valueAnalysis.ProductAnalisysValueRequestId);
            if (foundProductAnalisysValueRequest == null)
            {
                return (new ErrorResponse("Solicitação de análise do produto não encontrada", 404), null);
            }

            Supplier supplier = new Supplier { Id = 1, Name = "Fornecedor 1" };
            Supplier supplier2 = new Supplier { Id = 2, Name = "Fornecedor 2" };

            List<Supplier> suppliers = new List<Supplier>
            {
                supplier,
                supplier2
            };

            var foundSupplier = suppliers.Find(supplier => supplier.Id == valueAnalysis.SupplierId);
            if (foundSupplier == null)
            {
                return (new ErrorResponse("Fornecedor não encontrado", 404), null);
            }

            ValueAnalisys creeatedValueAnalisys = new ValueAnalisys { Id = 1, Price = valueAnalysis.Price, ProductAnalisysValueRequestId = valueAnalysis.ProductAnalisysValueRequestId, SupplierId = valueAnalysis.SupplierId };
            valueAnalisysList.Add(creeatedValueAnalisys);
        }

        return (null, valueAnalisysList);
    }
}
