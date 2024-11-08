namespace MauiAppHotel
{
    // Declaração parcial da classe MainPage que herda de ContentPage
    public partial class MainPage : ContentPage
    {
        // Inicialização da variável contadora
        int count = 0;

        // Construtor da classe MainPage
        public MainPage()
        {
            // Inicializa os componentes da página
            InitializeComponent();
        }

        // Método que é chamado quando o botão é clicado
        private void OnCounterClicked(object sender, EventArgs e)
        {
            // Incrementa a contagem
            count++;

            // Atualiza o texto do botão com base na contagem
            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            // Anuncia a nova contagem para o leitor de tela semântico
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}