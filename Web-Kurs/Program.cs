var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDirectoryBrowser();
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();
app.MapGet("/", async context=> {
    context.Response.ContentType = "text/html";
    await context.Response.SendFileAsync("wwwroot/index.html"); });

app.Run();
