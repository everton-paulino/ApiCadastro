using Cadasatro.Core;
using Cadasatro.Core.Interface;
using Cadastro.Core;
using Cadastro.Repository;
using Cadastro.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ICompanyService , CompanyService>();
builder.Services.AddSingleton<IEmployeeService, EmployeService>();
builder.Services.AddSingleton<ICompanyRepository, CompanyRepository>();
builder.Services.AddSingleton<IEmployeeRepository, EmployeeRepository>();

// Add services to the container.

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
