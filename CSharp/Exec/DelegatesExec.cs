using System;
using CSharp.Delegates;

namespace CSharp.Exec
{
    public class DelegatesExec : IExecutable
    {
        public void Execute(){
            /*
            * An object that knows how to call a method (or a group of methods)
            * A reference to a function
            * For designing extensible and flexible applications
            */
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.Resize;
            filterHandler += FilterOutsidePhotoFilter;
            processor.Process("C:\\Photos\\phot.jpg", filterHandler);

            Action<Photo> actionFilterHanlder = filters.ApplyContrast;
            processor.ProcessGenericDelegate("picture.jpg", actionFilterHanlder);
        }

        static void FilterOutsidePhotoFilter(Photo photo) {
            Console.WriteLine("Removing red eye!");
        }
    }
}