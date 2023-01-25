namespace Cats.ViewModels;
public class CatsViewModel : ICatsViewModels
{
    readonly ICatsModel Model;

    public CatsViewModel(ICatsModel model) => Model = model;

    public IReadOnlyCollection<Cat> Cats { get; private set; }

    public async Task GetCatsAsync() 
    {
        Cats = await Model.GetCatsAsync();
    }
}
