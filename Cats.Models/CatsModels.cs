namespace Cats.Models;
public class CatsModels : ICatsModel
{
    readonly HttpClient Client;
    readonly CatsEndpoints Endpoints;

    public CatsModels(HttpClient client, CatsEndpoints endpoints)
    {
        Client = client;
        Endpoints = endpoints;
    }

    public async Task<IReadOnlyCollection<Cat>> GetCatsAsync() =>
        await Client.GetFromJsonAsync<IReadOnlyCollection<Cat>>(Endpoints.Cats);
}
