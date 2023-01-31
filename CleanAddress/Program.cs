using CleanAddress.Dadata.Client;
using CleanAddress.Middlewares;
using CleanAddress.Model.Configuration;
using System.Reflection;

/// <summary>
/// �������� �������� CORS.
/// </summary>
const string CorsPolicy = "CorsPolicy";


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

// ��������� CORS ��������.
builder.Services.AddCors(options =>
{
    options.AddPolicy(CorsPolicy, policy =>
    {
        var corsConfiguration = builder.Configuration.GetSection("CORS").Get<CorsConfiguration>() ?? CorsConfiguration.Default;

        policy.WithOrigins(corsConfiguration.Origins)
              .WithMethods(corsConfiguration.Methods)
              .WithHeaders(corsConfiguration.Headers);

        if (corsConfiguration.AllowCredentials)
        {
            policy.AllowCredentials();
        }
    });
});


// ����������� �������.
var clientSettings = builder.Configuration.GetSection("DadataClientSettings").Get<DadataClientSettings>();
builder.Services.RegistarDadataClient(clientSettings);

// ��������� �������.
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(CorsPolicy);

app.UseHttpsRedirection();

app.UseAuthorization();

// middleware ��� ��������� ������.
app.UseMiddleware<ExceptionHandlerMiddleware>();

app.MapControllers();

app.Run();
