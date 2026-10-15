using Microsoft.EntityFrameworkCore;
using FluentValidation;
using FluentValidation.AspNetCore;
using INFRA;
using Application.Mapper;

var builder = WebApplication.CreateBuilder(args);

// 1. Configurar o Entity Framework Core com PostgreSQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// O primeiro argumento configura o AutoMapper, o segundo diz onde procurar os perfis
builder.Services.AddAutoMapper(cfg => { }, typeof(MappingProfile));

// 3. Configurar o FluentValidation de forma automática para os Controllers
// builder.Services.AddValidatorsFromAssemblyContaining<CriarProdutoDtoValidator>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // Configuração padrão do Swagger

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
