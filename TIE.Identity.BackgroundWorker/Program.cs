using TIE.Identity.BackgroundWorker;
using TIE.Identity.CompositionRoot;

var builder = Host.CreateApplicationBuilder(args);

var dependencyComposer = new DependencyComposer(builder.Services);

dependencyComposer.Compose(services => { services.AddHostedService<Worker>(); });

var host = builder.Build();

host.Run();