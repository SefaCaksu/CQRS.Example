using CQRS.Example.Manual_CQRS.Handlers.CommandHandler;
using CQRS.Example.Manual_CQRS.Handlers.QueryHandler;
using CQRS.Example.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

//Manuel CQRS HAndler
builder.Services.AddSingleton<CreateProductCommandHandler>()
                .AddSingleton<DeleteProductCommandHandler>()
                .AddSingleton<GetAllProductQueryHandler>()
                .AddSingleton<GetByIdProductQueryHandler>();

//Mediatr CQRS
builder.Services.AddMediatR(configuration => configuration.RegisterServicesFromAssembly(typeof(ApplicationDbContext).Assembly));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

