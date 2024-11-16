using SvtBL;
using Amazon.S3;
using Amazon.Runtime;

var builder = WebApplication.CreateBuilder(args);

// Add AWS service configuration from appsettings.json
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

// Add AWS S3 service
builder.Services.AddAWSService<IAmazonS3>();

// Register S3Services
builder.Services.AddSingleton<S3Services>();

// Add controllers and Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger UI for development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();