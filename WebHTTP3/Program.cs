var builder = WebApplication.CreateBuilder(args);
//builder.WebHost.ConfigureKestrel((ctx, options) =>
//{
//    options.ListenAnyIP(7777, opt =>
//    {
//        opt.Protocols = Microsoft.AspNetCore.Server.Kestrel.Core.HttpProtocols.Http1AndHttp2AndHttp3;
//        opt.UseHttps("Curso.pfx", ".......");
//    });
//});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
