using AutoMapper;

public class QuotationFileProfile: Profile{
    public QuotationFileProfile(){
        CreateMap<CreateQuotationFileDto,QuotationFile>();
    }
}