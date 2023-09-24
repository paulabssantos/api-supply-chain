using AutoMapper;

public class ProductAnalisysValueRequestProfile : Profile
{
    public ProductAnalisysValueRequestProfile()
    {
        CreateMap<ProductAnalisysValueRequest, ReadProductAnalysisValueRequestDto>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
    }
}
