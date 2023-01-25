namespace Simple.DependentyInjection;
public class DIHost
{
    static DIHost DIHostInstance;
    private DIHost() { }
    public IServiceCollection Services { get; private set; }
    public IConfiguration Configuration { get; private set; }
    public IServiceProvider ServiceProvider { get; private set; }
    public T GetService<T>() => ServiceProvider.GetService<T>();
    public T GetRequiredService<T>() => ServiceProvider.GetRequiredService<T>();
    public static DIHost CreateDefaultHost()
    {
        if(DIHostInstance is null)
        {
            DIHostInstance = new DIHost();
            DIHostInstance.LoadConfiguration();
            DIHostInstance.Services = new ServiceCollection();
        }
        return DIHostInstance;
    }

    public void Build()
    {
        DIHostInstance.ServiceProvider = DIHostInstance.Services.BuildServiceProvider();
    }

    private void LoadConfiguration() 
    {
        Configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", true)
            .AddEnvironmentVariables()
            .Build();
    }
}
