var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Подключаем поддержку статических файлов, чтобы обслуживать файлы из папки wwwroot
app.UseStaticFiles();

// Настраиваем маршрут по умолчанию на загрузку index.html из wwwroot
app.MapFallbackToFile("index.html");

app.Run();
