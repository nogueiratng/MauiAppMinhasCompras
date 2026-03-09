namespace MauiAppMinhasCompras.Views;

public partial class ListaProduto : ContentPage
{
	public ListaProduto()
	{
		InitializeComponent();
	}
<<<<<<< HEAD

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new Views.NovoProduto());
		}
		catch (Exception ex)
		{
			DisplayAlert("Ops!", ex.Message, "OK");
		}
    }
=======
>>>>>>> fd04fca7bd29b75a4532fe3b6690102664185527
}