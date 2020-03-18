namespace CSharp.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();

            if (rating == 0)
            {
                System.Console.WriteLine("Promoted to level 1");
            }
            else
            {
                System.Console.WriteLine("Promoted to level 2");
            }
        }

        private int CalculateRating()
        {
            /* 
             * Implementation detail of this class 
             * It do not have to be public
             * private can't be used by its children
             */
            return 0;
        }
    }

    public class GoldUser : User {

        public void OfferVoucher() 
        {
            // var rat = this.CalculateRating();
        }

    }

}