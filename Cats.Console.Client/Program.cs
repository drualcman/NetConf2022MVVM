DIHost Host = DIHost.CreateDefaultHost();
Host.Services.AddConsoleServices(
    Host.Configuration.GetSection("CatsEndpoints").Get<CatsEndpoints>()
    );
Host.Build();

ICatsView view = Host.GetRequiredService<ICatsView>();
await view.RenderCatsAsync();

