using AutoMapper;

public class CreateValueAnalysisService
{
    private readonly IMapper _mapper;
    private readonly IValueAnalisysRepository _valueAnalysisRepository;

    public CreateValueAnalysisService(IValueAnalisysRepository valueAnalysisRepository, IMapper mapper)
    {
        _mapper = mapper;
        _valueAnalysisRepository = valueAnalysisRepository;
    }
    public (ErrorResponse?, List<ValueAnalisys>?) Execute(List<CreateValueAnalysisDto> data)
    {
        var createdValueAnalysis = _valueAnalysisRepository.Create(_mapper.Map<List<ValueAnalisys>>(data));
        return (null, createdValueAnalysis);
    }
}
