using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowAllOrigins", builder =>
        {
            builder
                .AllowAnyOrigin()
                .AllowAnyMethod() 
                .AllowAnyHeader();
        });
    });
//Database
var connectionString = builder.Configuration.GetConnectionString("SupplyChain");
builder.Services.AddDbContext<MySqlContext>(opts => opts.UseLazyLoadingProxies().UseMySql(connectionString,ServerVersion.AutoDetect(connectionString)));

//Repositories
builder.Services.AddScoped<IQuotationRepository,QuotationRepository>();
builder.Services.AddScoped<ISupplierRepository,SupplierRepository>();

// Add services to the container.
builder.Services.AddScoped<CreateValueAnalisysService>();
builder.Services.AddScoped<CreatePurchaseOrderService>();
builder.Services.AddScoped<FindQuotationService>();
builder.Services.AddScoped<ListSuppliersService>();

//Libraries
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
