using System;
using System.Threading;

namespace CSharp.Events
{
    public class VideoEncoder
    {
        // 1 - Define a Delegate
        // 2 - Define an Event based on the delegate
        // 3 - Raise the event
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding...");
            Thread.Sleep(3000);
            OnVideoEncoded(); // 3 step
        }

        /* 1st param source of the event. The class that is sending or publishing the event
         * 2nd param any aditional data to send
         * Event - VideoEncoded, Delegate - EventHandler
        */
        public delegate void VideoEncodedEventHandler(object source, EventArgs args); // 1 step
        public event VideoEncodedEventHandler VideoEncoded; // 2 step

        protected virtual void OnVideoEncoded()
        { // 3 step
            if (VideoEncoded != null) // check the subscribers
                VideoEncoded(this, EventArgs.Empty);
        }

    }
}