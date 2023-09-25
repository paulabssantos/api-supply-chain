using AutoMapper;

public class CreateQuotationFileService
{
    private readonly IMapper _mapper;
    private readonly IHostEnvironment _environment;

    private readonly IQuotationFileRepository _quotationFileRepository;

public CreateQuotationFileService(IQuotationFileRepository quotationFileRepository, IMapper mapper, IHostEnvironment environment)
{
    _quotationFileRepository = quotationFileRepository;
    _mapper = mapper;
    _environment = environment;
}

    public void Execute(List<IFormFile> files, int id)
    {
        foreach (var file in files)
        {
            if (file != null && file.Length > 0)
            {   
                Console.WriteLine(_environment.ContentRootPath);
                var uploadsPath = Path.Combine(_environment.ContentRootPath, "Uploads");

                if (!Directory.Exists(uploadsPath))
                {
                    Directory.CreateDirectory(uploadsPath);
                }

                var filename = Guid.NewGuid().ToString() + "_" + file.FileName;
                var filePath = Path.Combine(uploadsPath, filename);
                using var stream = new FileStream(filePath, FileMode.Create);
                file.CopyToAsync(stream);

                CreateQuotationFileDto createQuotationFileDto = new(){
                    FilePath = filePath,
                    QuotationId = id,
                };

                _quotationFileRepository.Create(_mapper.Map<QuotationFile>(createQuotationFileDto));

                }
        }
    }
}
