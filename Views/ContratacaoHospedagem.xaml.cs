using Microsoft.Maui.Controls; // Importa o namespace de controles do MAUI, que cont�m elementos de interface do usu�rio
using MauiAppHotel.Views; // Importa as views do projeto MauiAppHotel, permitindo o uso de outras p�ginas no projeto

namespace MauiAppHotel.Views
{
    // Defini��o parcial da classe ContratacaoHospedagem, que herda de ContentPage para representar uma p�gina de conte�do no app
    public partial class ContratacaoHospedagem : ContentPage
    {
        App PropriedadesApp;

        // Construtor da classe ContratacaoHospedagem
        public ContratacaoHospedagem()
        {
            // Inicializa os componentes da p�gina definidos no arquivo XAML
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;
            pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;
            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

            dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
            dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
        }

        // M�todo acionado ao clicar no bot�o "Avan�ar"
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Navega para a p�gina HospedagemContratada
                Navigation.PushAsync(new HospedagemContratada());
            }
            catch (Exception ex)
            {
                // Exibe um alerta caso ocorra um erro durante a navega��o
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        // M�todo ass�ncrono acionado ao clicar no bot�o "Sobre"
        private async void OnSobreClicked(object sender, EventArgs e)
        {
            // Navega para a p�gina Sobre de forma ass�ncrona
            await Navigation.PushAsync(new SobrePage());
        }

        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = sender as DatePicker;

            DateTime data_selecionada_checkin = elemento.Date;
            dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
            dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
        }
    }
}