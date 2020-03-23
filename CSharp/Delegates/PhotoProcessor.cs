namespace CSharp.Delegates
{
    public class PhotoProcessor
    {
        /* Pass a delegate */
        public void Process(string path, PhotoFilterHandler photoFilterHandler)
        {
            var photo = Photo.Load(path);

            /* Code not extensible 
            * More difficult to create another filter.
            * Each new filter the class must be recompiled
            */

            /* Using delegates. Instead of having these hardcoded */
            // var filters = new PhotoFilters();
            // filters.ApplyBrightness(photo);
            // filters.ApplyContrast(photo);
            // filters.Resize(photo);

            photoFilterHandler(photo); // This delegate points to the methods.
            photo.Save();
        }

        /*Delegate must have the same signature of the methods. In this case, returns void and receive Photo as parameter*/
        public delegate void PhotoFilterHandler(Photo photo);


    }
}