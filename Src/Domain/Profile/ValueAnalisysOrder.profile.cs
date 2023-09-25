using AutoMapper;

public class ValueAnalisysProfile : Profile{
    public ValueAnalisysProfile(){
        CreateMap<CreateValueAnalysisDto,ValueAnalisys>();
        CreateMap<ValueAnalisys,ReadValueAnalisysDto>();
    }
}