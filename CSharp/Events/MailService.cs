using System;

namespace CSharp.Events
{
    public class MailService
    {   /* Subscriber */
        /* Responsible for sending email once the video is enconded */
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"MailService sending email. {e.Video.Title}");    
        }
    }
}