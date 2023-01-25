namespace Cats.BusinesObjects.Interfaces;
public interface ICatsModel
{
    Task<IReadOnlyCollection<Cat>> GetCatsAsync();
}
