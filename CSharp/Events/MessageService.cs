using System;

namespace CSharp.Events
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e){
            Console.WriteLine($"Sending SMS! \t{e.Video.Title}");
        }
    }
}