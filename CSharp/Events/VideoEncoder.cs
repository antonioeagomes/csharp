using System;
using System.Threading;

namespace CSharp.Events
{
    public class VideoEncoder
    {
        // 1 - Define a Delegate
        // 2 - Define an Event based on the delegate
        // 3 - Raise the event

        /* 1st param source of the event. The class that is sending or publishing the event
         * 2nd param any aditional data to send
         * Event - VideoEncoded, Delegate - EventHandler
        */
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); // 1 

        /* .net has a delegate called EventHandler and EventHandler<TEventArgs>*/
        
        public event VideoEncodedEventHandler VideoEncoded; // 2 

        /* Instead of create a delegate and the event. We just use the EventHandler */
        public event EventHandler<VideoEventArgs> VideoEncodedTwo;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding...");
            Thread.Sleep(3000);
            OnVideoEncoded(video); // 3 
        }
        protected virtual void OnVideoEncoded(Video video)
        { // 3 step
            if (VideoEncoded != null) // check the subscribers
                VideoEncoded(this, new VideoEventArgs() { Video =  video} );
            
            if (VideoEncodedTwo != null) // check the subscribers
                VideoEncodedTwo(this, new VideoEventArgs() { Video =  video} );
        }
    }
    public class VideoEventArgs : EventArgs {
        public Video Video { get; set; }
    }
}