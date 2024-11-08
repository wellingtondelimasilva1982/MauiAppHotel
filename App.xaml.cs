using MauiAppHotel.Models;

namespace MauiAppHotel
{
    // Declaração parcial da classe App que herda de Application
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50.0,
                ValorDiariaCrianca = 25.0
            },
            new Quarto()
            {
                Descricao = "Suíte Crise",
                ValorDiariaAdulto = 35.0,
                ValorDiariaCrianca = 12.5
            },
        };




            
        // Construtor da classe App
        public App()
        {
            // Inicializa os componentes da aplicação
            InitializeComponent();

            // Define a página principal do aplicativo como uma NavigationPage contendo a página ContratacaoHospedagem
            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        // Método protegido que cria a janela da aplicação
        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Chama o método base para criar a janela
            var window = base.CreateWindow(activationState);

            // Define a largura da janela
            window.Width = 400;
            // Define a altura da janela
            window.Height = 600;

            // Retorna a janela criada
            return window;
        }
    }
}
