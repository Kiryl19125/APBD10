using APBD10.Contexts;
using APBD10.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddDbContext<DatabaseContext>(
    opt =>
    {
        opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/api/accounts/{id:int}", async (int id, IAccountService service) =>
    {
        return Results.Ok(await service.GetAccountWithCart(id));
    }
);
app.Run();
