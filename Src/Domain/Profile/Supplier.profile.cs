using AutoMapper;

public class SupplierProfile: Profile{
    public SupplierProfile(){
        CreateMap<Supplier,ReadSupplierDto>();
    }
}