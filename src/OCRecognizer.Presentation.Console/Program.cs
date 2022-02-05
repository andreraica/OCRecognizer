using OCRecognizer.Domain.Services;

namespace OCRecognizer.Presentation.Console
{
    public class Program
    {
        static void Main()
        {
            var defaultImageUrl = "http://www.google.com/images/logos/ps_logo2.png";
            System.Console.WriteLine($"Press ENTER to use default google logo Url: {defaultImageUrl}");

            var userImageUrl = System.Console.ReadLine();
            var imageUrl = !string.IsNullOrEmpty(userImageUrl) ? userImageUrl : defaultImageUrl;

            try
            {
                var imageBytes = ImageService.GetBytesFromUrl(imageUrl);
                var imageText = ImageService.GetString(imageBytes);
                System.Console.WriteLine($"Texto identificado: {imageText}");
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine($"Ocorreu um Erro (verifique as configurações e a URL inserida: {ex.Message}");
            }

            System.Console.ReadLine();
        }
    }
}
