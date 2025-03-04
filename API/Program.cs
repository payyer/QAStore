using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>((options => {
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
}));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(opt =>
{
    opt.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:5173");
});


app.UseAuthorization();

app.MapControllers();


using (var scope = app.Services.CreateScope()) 
{
    var context = scope.ServiceProvider.GetRequiredService<StoreContext>();
    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

    try 
    {
        context.Database.Migrate();
        DbInitializer.Initialize(context); 
    }
    catch (Exception ex) 
    {
        logger.LogError(ex, "Problem migrating data!");
    }
}

app.Run();
