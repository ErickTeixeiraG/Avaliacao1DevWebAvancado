var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

//Nomes:
//Guilherme Garcia dos Santos
//Natã Batista
//Pedro Henrique
//Erick