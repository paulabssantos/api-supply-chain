using AutoMapper;

public class QuotationProfile: Profile{
    public QuotationProfile(){
        CreateMap<Quotation,ReadQuotationDto>();
    }
}