using Microsoft.Maui.Controls; // Importa o namespace de controles do MAUI

namespace MauiAppHotel.Views
{
    // Definição parcial da classe SobrePage que herda de ContentPage
    public partial class SobrePage : ContentPage
    {
        // Construtor da classe SobrePage
        public SobrePage()
        {
            // Inicializa os componentes da página
            InitializeComponent();
        }

        // Método assíncrono para navegar de volta para a página anterior
        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            // Navega para a página anterior na pilha de navegação
            await Navigation.PopAsync();
        }
    }
}