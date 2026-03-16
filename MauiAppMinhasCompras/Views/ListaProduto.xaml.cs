using MauiAppMinhasCompras.Models;
using SQLitePCL;
using System.Collections.ObjectModel;

namespace MauiAppMinhasCompras.Views;

public partial class ListaProduto : ContentPage
{
	ObservableCollection<Produto> lista = new ObservableCollection<Produto>(); 
	
	public ListaProduto()
	{
		InitializeComponent();

		lst_produtos.ItemsSource = lista;
	}

    protected async override void OnAppearing()
    {
		List<Produto> tmp = await App.Db.GetAll();

		tmp.ForEach(i => lista.Add(i));
    }

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

	private async void txt_search_TextChanged(object sender, TextChangedEventArgs e) 
	{
		string q = e.NewTextValue;

		lista.Clear();

        List<Produto> tmp = await App.Db.Search(q);

        tmp.ForEach(i => lista.Add(i));
    }

	private void ToolbarItem_Clicked_1(object sender, EventArgs e) 
	{
		double soma = lista.Sum(i => i.Total);

		string msg = $"O total é {soma:C}";

		DisplayAlert("Total dos Produtos", msg, "OK");
	}

	private async void MenuItem_Clicked(object sender, EventArgs e) 
	{
		try
		{
			MenuItem Selecionado = sender as MenuItem;

			Produto p = Selecionado.BindingContext as Produto;

            bool confirm = await DisplayAlert("Tem Certeza?", "Remover Produto?", "SIM", "NÃO");

			if (confirm) 
			{
				await App.Db.Delete(p.Id);
				lista.Remove(p);
			}
		}
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
	}
}