using System;

namespace CSharp.Interfaces
{
    public interface IActivity
    {
         void Execute();
    }

    public class VideoUploader : IActivity {
        public void Execute() {
            Console.WriteLine("The video is uploading");
        }
    }

    public class SendMail : IActivity {
        public void Execute() {
            Console.WriteLine("Sending mail...");
        }
    }

    public class WebServiceConnection : IActivity {
        public void Execute() {
            Console.WriteLine("Calling a web service");
        }
    }

    public class VideoProcessor : IActivity {
        public void Execute() {
            Console.WriteLine("Video status: Processing");
        }
    }
}