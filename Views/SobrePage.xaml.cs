using Microsoft.Maui.Controls; // Importa o namespace de controles do MAUI

namespace MauiAppHotel.Views
{
    // Defini��o parcial da classe SobrePage que herda de ContentPage
    public partial class SobrePage : ContentPage
    {
        // Construtor da classe SobrePage
        public SobrePage()
        {
            // Inicializa os componentes da p�gina
            InitializeComponent();
        }

        // M�todo ass�ncrono para navegar de volta para a p�gina anterior
        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            // Navega para a p�gina anterior na pilha de navega��o
            await Navigation.PopAsync();
        }
    }
}