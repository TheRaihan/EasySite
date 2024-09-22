using EasySite.Settings;
using EasySite.Repositories;
using EasySite.Services;

var builder = WebApplication.CreateBuilder(args);

// Register MongoDB settings
builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection("MongoDBSettings"));

// Register services and repositories
builder.Services.AddSingleton<UserRepository>();
builder.Services.AddScoped<UserService>();

// Add controllers
builder.Services.AddControllers();

// builder.Services.AddCors(options =>
// {
//     options.AddPolicy("AllowReactApp",
//         policy => policy.AllowAnyOrigin()
//                         .AllowAnyMethod()
//                         .AllowAnyHeader());
// });

var app = builder.Build();

app.UseCors("AllowReactApp");
app.MapControllers();
app.Run();
