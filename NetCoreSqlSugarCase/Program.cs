using NetCoreSqlSugarCase.config;
using SqlSugar;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// ע��SqlSugar
builder.Services.AppSqlsugarSetup(builder.Configuration);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    #region SqlSugar����ʵ����
    //app.CreateMapper();
    #endregion
}

app.UseAuthorization();

app.MapControllers();

app.Run();


