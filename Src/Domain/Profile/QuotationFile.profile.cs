using AutoMapper;

public class QuotationFileProfile: Profile{
    public QuotationFileProfile(){
        CreateMap<QuotationFile,QuotationFile>();
    }
}