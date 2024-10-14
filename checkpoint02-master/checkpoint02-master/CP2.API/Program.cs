using CP2.API.Application.Interfaces;
using CP2.API.Application.Services;
using CP2.API.Infrastructure.Data.AppData;
using CP2.API.Infrastructure.Data.Repositories;
using CP2.API.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseOracle(builder.Configuration.GetConnectionString("Oracle"));
});

builder.Services.AddTransient<IFornecedorRepository, FornecedorRepository>();
builder.Services.AddTransient<IFornecedorApplicationService, FornecedorApplicationService>();
builder.Services.AddTransient<IVendedorRepository, VendedorRepository>();
builder.Services.AddTransient<IVendedorApplicationService, VendedorApplicationService>();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddSwaggerGen(c => {
    c.EnableAnnotations();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
