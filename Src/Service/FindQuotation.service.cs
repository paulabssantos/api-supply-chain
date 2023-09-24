using AutoMapper;

public class FindQuotationService
{
    private readonly IQuotationRepository _quotationRepository;
    private readonly IMapper _mapper;

    public FindQuotationService(IQuotationRepository quotationRepository,IMapper mapper)
    {
        _quotationRepository = quotationRepository;
        _mapper = mapper;
    }
    public (ErrorResponse?,ReadQuotationDto?) Execute(int QuotationId)
    {   
        var quotation = _quotationRepository.Find(QuotationId);
        
        if(quotation == null){
            return (new ErrorResponse("Cotação não encontrada",404),null);
        }
        return (null,_mapper.Map<ReadQuotationDto>(quotation));
    }
}