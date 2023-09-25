using AutoMapper;

public class CreatePurchaseOrderService
{
    private readonly IPurchaseOrderRepository _purchaseOrderRepository;
    private readonly IValueAnalisysRepository _valueAnalysisRepository;
    private readonly IMapper _mapper;

    public CreatePurchaseOrderService(IMapper mapper,IPurchaseOrderRepository purchaseOrderRepository, IValueAnalisysRepository valueAnalisysRepository){
        _purchaseOrderRepository = purchaseOrderRepository;
        _valueAnalysisRepository = valueAnalisysRepository;
        _mapper = mapper;
    }
    public (ErrorResponse?, ReadPurchaseOrderDto?) Execute(CreatePurchaseOrderDto data)
    {

        if((int)data.Status == (int)PurchaseOrderStatusEnum.Repproved && (string.IsNullOrEmpty(data.Justification) || string.IsNullOrWhiteSpace(data.Justification))){
            return(new ErrorResponse("Justificativa não pode ficar vazia quando o status é reprovado"),null);
        }
        var createdPurchaseOrder = _purchaseOrderRepository.Create(_mapper.Map<PurchaseOrder>(data));
        foreach (var valueAnalysisId in data.ValueAnalysisId)        {

            _valueAnalysisRepository.UpdatePurchaseOrder(valueAnalysisId,createdPurchaseOrder.Id);
        }

        return (null, _mapper.Map<ReadPurchaseOrderDto>(createdPurchaseOrder));
    }
}
