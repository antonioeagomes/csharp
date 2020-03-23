using System;

namespace CSharp.Delegates
{
    public class PhotoProcessor
    {
        
        /*Delegate must have the same signature of the methods. In this case, returns void and receive Photo as parameter*/
        public delegate void PhotoFilterHandler(Photo photo);
        
        public void Process(string path, PhotoFilterHandler photoFilterHandler)
        {/* Pass a delegate */
            var photo = Photo.Load(path);

            /* Using delegates. Instead of having these hardcoded */
            photoFilterHandler(photo); // This delegate points to the methods.
            photo.Save();
        }
        public void ProcessGenericDelegate(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);            
            
            /* We can use as well generic delegates Action or Func 
            * System.Action<> // Up to 15 params. returns void
            * System.Func // Func points to methods that return values out TResult
            */

            filterHandler(photo);
            photo.Save();
        }

        public void ProcessWithoutDelegate(string path)
        {
            var photo = Photo.Load(path);

            /* Code not extensible 
            * More difficult to create another filter.
            * Each new filter the class must be recompiled
            *
            * Hardcoded */
            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);

            photo.Save();
        }
    }
}