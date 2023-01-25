namespace Cats.BusinesObjects.Interfaces;
public interface ICatsViewModels
{
    IReadOnlyCollection<Cat> Cats { get; }
    
    Task GetCatsAsync();
}
