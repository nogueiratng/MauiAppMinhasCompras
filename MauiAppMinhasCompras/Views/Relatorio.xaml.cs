namespace MauiAppMinhasCompras.Views;

public partial class Relatorio : ContentPage
{
    public Relatorio()
    {
        InitializeComponent();
    }
    private async void OnFiltrarClicked(object sender, EventArgs e)
    {
        try
        {
            DateTime inicio = dtp_inicio.Date;
            DateTime fim = dtp_fim.Date;

            var lista = await App.Db.GetProdutosPorPeriodo(inicio, fim);

            lst_produtos.ItemsSource = lista;
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", ex.Message, "OK");
        }
    }
}