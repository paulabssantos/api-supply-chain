using AutoMapper;

public class ListSuppliersService{
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;
    public ListSuppliersService(ISupplierRepository supplierRepository,IMapper mapper){
        _supplierRepository = supplierRepository;
        _mapper = mapper;
    }
    public (ErrorResponse?,List<ReadSupplierDto>?) Execute(){
        var suppliers =  _supplierRepository.List();
        return (null,_mapper.Map<List<ReadSupplierDto>>(suppliers));
    }
}