var builder = WebApplication.CreateBuilder(args);

// 加入 Controller 支援
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger 設定（可選）
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

// 啟用 Controller 路由（這是關鍵！）
app.UseAuthorization();
app.MapControllers(); // ← 這行讓 LineController 能接收請求

app.Run();
