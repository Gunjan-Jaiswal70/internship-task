var builder = WebApplication.CreateBuilder(args);

// --- YE LINE ZAROORI HAI ---
// Controllers ki service add karein
builder.Services.AddControllers();

// Swagger setup (Jo aapke code mein pehle se hai)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Development environment mein Swagger UI dikhane ke liye
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Controllers ke routes map karne ke liye
app.MapControllers();

app.Run();