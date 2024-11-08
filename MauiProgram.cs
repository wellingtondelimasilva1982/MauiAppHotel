using Microsoft.Extensions.Logging; // Importa o namespace para logging

namespace MauiAppHotel
{
    // Classe estática que configura e cria a aplicação MAUI
    public static class MauiProgram
    {
        // Método que cria e retorna a aplicação MAUI
        public static MauiApp CreateMauiApp()
        {
            // Cria o construtor da aplicação MAUI
            var builder = MauiApp.CreateBuilder();

            // Configura a aplicação, especificando a classe principal e as fontes
            builder
                .UseMauiApp<App>() // Usa a classe App como a aplicação principal
                .ConfigureFonts(fonts => // Configura as fontes da aplicação
                {
                    // Adiciona as fontes OpenSans e Kalam com nomes específicos
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Kalam-Bold.ttf", "KalamBold");
                    fonts.AddFont("Kalam-Light.ttf", "KalamLight");
                    fonts.AddFont("Kalam-Regular.ttf", "Kalam");
                });

#if DEBUG
            // Adiciona o provedor de logging para debug quando em modo DEBUG
            builder.Logging.AddDebug();
#endif

            // Constrói e retorna a aplicação MAUI configurada
            return builder.Build();
        }
    }
}