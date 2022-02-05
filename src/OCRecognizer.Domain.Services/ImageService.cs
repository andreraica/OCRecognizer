using System.Net;
using Tesseract;

namespace OCRecognizer.Domain.Services
{
    public static class ImageService
    {
        public static string GetString(byte[] imageBytes)
        {
            using (var engine = new TesseractEngine("tessdata", "eng", EngineMode.Default))
            {
                engine.SetVariable("debug_file", false);

                using (var image = Pix.LoadFromMemory(imageBytes))
                {
                    using (var page = engine.Process(image))
                    {
                        return page.GetText();
                    }
                }
            }
        }

        public static byte[] GetBytesFromUrl(string imageUrl)
        {
            using (var webClient = new WebClient())
            {
                return webClient.DownloadData(imageUrl);
            }
        }
    }
}
