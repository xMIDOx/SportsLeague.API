using SportsLeague.API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureConnectionString(builder);
builder.Services.ConfigureAppServices();
builder.Services.AddCors();
builder.Services.AddAutoMapper(typeof(Program));


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

app.UseCors(x => x.
AllowAnyHeader().
AllowAnyMethod().
WithOrigins("http://localhost:4200"));

app.UseAuthorization();

app.MapControllers();

app.Run();
