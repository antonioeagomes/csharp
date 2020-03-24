using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp.Async
{
    public class MainWindow
    {
        public void ButtonClick()
        {
            Console.WriteLine($"Sync {DateTime.Now}");
            DownloadHtml("http://msdn.microsoft.com");
            Console.WriteLine($"Sync {DateTime.Now}");
        }

        public async Task ButtonClickAsync()
        {
            Console.WriteLine($"Async {DateTime.Now}");
            await DownloadAsync("http://msdn.microsoft.com");
            Console.WriteLine($"Async {DateTime.Now}");
        }

        private void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);
            Thread.Sleep(2000);
            using (var streamWriter = new StreamWriter(@"C:\Users\aeag\Documents\Dev\CSharp\csharp\CSharp\result.html"))
            {
                streamWriter.Write(html);
            }
        }

        private async Task DownloadAsync(string url) {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);
            Thread.Sleep(2000);
            using (var streamWriter = new StreamWriter(@"C:\Users\aeag\Documents\Dev\CSharp\csharp\CSharp\resultAsync.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }
    }
}