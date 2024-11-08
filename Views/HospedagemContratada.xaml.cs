namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Navega para a página HospedagemContratada
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            // Exibe um alerta caso ocorra um erro durante a navegação
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}