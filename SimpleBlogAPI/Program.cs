var builder = WebApplication.CreateBuilder(args);

// Controllers aur Swagger Services add karein
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger UI ko Development mode mein enable karein
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers(); // Isse aapka PostsController kaam karega

app.Run();