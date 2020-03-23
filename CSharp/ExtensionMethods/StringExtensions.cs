using System.Linq;

namespace CSharp.ExtensionMethods
{ /* We can use the same namespace as String class, System */
    public static class StringExtensions
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new System.Exception("Error");

            if(numberOfWords == 0)
                return "";

            var words = str.Split(' ');

            if(words.Length <= numberOfWords)
                return str;
            
            return $"{string.Join(" ", words.Take(numberOfWords))}...";
        }
    }

    public class Post {
        private string _post;
        public void CreatePost(string post) {
            _post = post;
        }
        public string GetPost() {
            return _post;
        }
        public string ShowPostResume() {

            return _post.Shorten(5);
        }
    }
}