using CSharp.Events;

namespace CSharp.Exec
{
    public class EventsExe : IExecutable
    {
        /*
        * Event is a mechanism for communication between objects
        * Used in building loosely coupled applications
        */
        public void Execute()
        {
            MainMethod();
        }   

        public void MainMethod()
        {
            var video = new Video() { Title = "Kitty and puppy" };
            var encoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService();
            encoder.VideoEncodedTwo += mailService.OnVideoEncoded;
            encoder.VideoEncoded += messageService.OnVideoEncoded;
            encoder.Encode(video);

            /* Creating subscribers */
        }
    }
}