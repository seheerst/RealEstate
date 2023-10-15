using RealEstate_Api.Models.DapperContext;
using RealEstate_Api.Repositories.AboutDetailRepository;
using RealEstate_Api.Repositories.AboutServiceRepository;
using RealEstate_Api.Repositories.BottomGridRepositories;
using RealEstate_Api.Repositories.CategoryRepository;
using RealEstate_Api.Repositories.EmployeeRepositories;
using RealEstate_Api.Repositories.PopulerCityRepositories;
using RealEstate_Api.Repositories.ProductRepository;
using RealEstate_Api.Repositories.StepRepositories;
using RealEstate_Api.Repositories.TestimonialRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<Context>();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IAboutDetailRepository, AboutDetailRepository>();
builder.Services.AddTransient<IAboutServiceRepository, AboutServiceRepository>();
builder.Services.AddTransient<IBottomGridRepository, BottomGridRepository>();
builder.Services.AddTransient<IPopulerCityRepository, PopulerCityRepository>();
builder.Services.AddTransient<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddTransient<IStepRepository, StepRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
