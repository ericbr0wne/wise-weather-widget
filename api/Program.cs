using api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<SmhiService>();
builder.Services.AddHttpClient<SmhiService>();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
