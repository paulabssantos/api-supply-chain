using AutoMapper;

public class PurchaseOrderProfile: Profile{
    public PurchaseOrderProfile(){
        CreateMap<CreatePurchaseOrderDto,PurchaseOrder>();
    }
}