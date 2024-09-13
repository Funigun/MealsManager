var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(config =>
{
    config.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Meals Manager API",
        Version = "v1",
        Description = "API for Cookbooks / Receipes management",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact() 
        { 
            Name = "Funigun", 
            Url = new Uri(@"https://github.com/Funigun/MealsManager/tree/master") 
        },
    });
    var filePath = Path.Combine(AppContext.BaseDirectory, "MealsManager.API.xml");
    config.IncludeXmlComments(filePath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MealManagerWebApp"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
