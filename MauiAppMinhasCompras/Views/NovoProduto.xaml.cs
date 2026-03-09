<<<<<<< HEAD
using MauiAppMinhasCompras.Models;
using System.Threading.Tasks;

=======
>>>>>>> fd04fca7bd29b75a4532fe3b6690102664185527
namespace MauiAppMinhasCompras.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}
<<<<<<< HEAD

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Produto p = new Produto
			{
				Descricao = txt_descricao.Text,
				Quantidade = Convert.ToDouble(txt_quantidade.Text),
				Preco = Convert.ToDouble(txt_preco.Text)
			};

			await App.Db.Insert(p);
			await DisplayAlert("Sucesso!", "Registro Inserido", "OK");

		}
		catch (Exception ex) 
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
    }
=======
>>>>>>> fd04fca7bd29b75a4532fe3b6690102664185527
}