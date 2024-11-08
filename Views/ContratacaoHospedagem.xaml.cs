using Microsoft.Maui.Controls; // Importa o namespace de controles do MAUI, que contém elementos de interface do usuário
using MauiAppHotel.Views; // Importa as views do projeto MauiAppHotel, permitindo o uso de outras páginas no projeto

namespace MauiAppHotel.Views
{
    // Definição parcial da classe ContratacaoHospedagem, que herda de ContentPage para representar uma página de conteúdo no app
    public partial class ContratacaoHospedagem : ContentPage
    {
        App PropriedadesApp;

        // Construtor da classe ContratacaoHospedagem
        public ContratacaoHospedagem()
        {
            // Inicializa os componentes da página definidos no arquivo XAML
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;
            pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;
            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

            dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
            dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
        }

        // Método acionado ao clicar no botão "Avançar"
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Navega para a página HospedagemContratada
                Navigation.PushAsync(new HospedagemContratada());
            }
            catch (Exception ex)
            {
                // Exibe um alerta caso ocorra um erro durante a navegação
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        // Método assíncrono acionado ao clicar no botão "Sobre"
        private async void OnSobreClicked(object sender, EventArgs e)
        {
            // Navega para a página Sobre de forma assíncrona
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