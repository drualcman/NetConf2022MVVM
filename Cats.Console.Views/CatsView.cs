namespace Cats.Console.Views;
public class CatsView : ICatsView
{
    readonly ICatsViewModels ViewModel;

    public CatsView(ICatsViewModels viewModel) => ViewModel = viewModel;

    public async Task RenderCatsAsync()
    {
        await ViewModel.GetCatsAsync();
        foreach(Cat item in ViewModel.Cats)
        {
            WriteTop();
            WriteMiddle(item.Id.ToString());
            WriteMiddle(item.Name);
            WriteMiddle(item.Description);
            WriteMiddle(item.BasePrice.ToString($"$ #,###.##"));
            WriteBottom();
        }
    }
    void WriteTop() =>
        System.Console.WriteLine(" ╔{0}╗", new string('═', 70));
    void WriteMiddle(string text) =>
        System.Console.WriteLine(" ║ {0,-68} ║", text); 
    void WriteBottom() =>
        System.Console.WriteLine(" ╚{0}╝", new string('═', 70));
}
