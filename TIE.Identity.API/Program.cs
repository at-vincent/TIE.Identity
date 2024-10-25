using TIE.Identity.CompositionRoot;

var builder = WebApplication.CreateBuilder(args);

var dependencyComposer = new DependencyComposer(builder.Services);

dependencyComposer.Compose(services => { services.AddControllers(); });

var app = builder.Build();

app.Run();