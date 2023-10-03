using MagicVilla.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(option => { option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));  });
 builder.Services.AddControllers().AddNewtonsoftJson();

//Log.Logger = new LoggerConfiguration()
 //   .MinimumLevel.Debug().WriteTo.File("log/villaLogs.txt", rollingInterval.Day).CreateLogger();


//this committed line below is use to set postman to work  to work with json file
//builder.Services.AddControllers(options => { options.ReturnHttpNotAcceptabl   e = true; }).AddNewtonsoftJson();

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
