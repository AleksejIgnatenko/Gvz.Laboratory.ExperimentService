using Gvz.Laboratory.ExperimentService;
using Gvz.Laboratory.ExperimentService.Abstractions;
using Gvz.Laboratory.ExperimentService.Infrastructure;
using Gvz.Laboratory.ExperimentService.Kafka;
using Gvz.Laboratory.ExperimentService.Repositories;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<GvzLaboratoryExperimentServiceDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IResearchRepository, ResearchRepository>();
builder.Services.AddScoped<IExperimentRepository, ExperimentRepository>();

builder.Services.AddSingleton(() =>
{
    var config = new TypeAdapterConfig();
    new RegisterMapper().Register(config);
    return config;
});
builder.Services.AddScoped<IUserMapper, UserMapper>();

builder.Services.AddSingleton<UserKafkaConsumer>();
builder.Services.AddHostedService(provider => provider.GetRequiredService<UserKafkaConsumer>());


var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
