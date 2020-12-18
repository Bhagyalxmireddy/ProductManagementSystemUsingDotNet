using System;
using System.Collections.Generic;

namespace ProductManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management system");
            List<ProductReview> productReviewlist = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 1, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 3, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 4, UserId = 4, Rating = 4, Review = "bad", IsLike = false },
                new ProductReview() { ProductId = 5, UserId = 5, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 6, UserId = 6, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 7, UserId = 7, Rating = 5, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 8, UserId = 8, Rating = 4, Review = "nice", IsLike = false } ,
                new ProductReview() { ProductId = 9, UserId = 9, Rating = 3, Review = "bad", IsLike = false },
                new ProductReview() { ProductId = 10, UserId = 10, Rating = 4, Review = "bad", IsLike = false},
                new ProductReview() { ProductId = 11, UserId = 11, Rating = 4, Review = "bad", IsLike = false},
                new ProductReview() { ProductId = 12, UserId = 12, Rating = 3, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 13, UserId = 13, Rating = 3, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 14, UserId = 14, Rating = 2, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 15, UserId = 15, Rating = 1, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 16, UserId = 16, Rating = 4, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 17, UserId = 17, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 18, UserId = 18, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 3, UserId = 1, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 17, UserId = 1, Rating = 5, Review = "Good", IsLike = true }

            };
           /* foreach(var list in productReviewlist)
             {
                 Console.WriteLine("ProductId:-" + list.ProductId + " " + "UserId:-" + list.UserId + " " + "Rating: " + list.Rating + " " + "Rivew: " + list.Review + " " +
                     "ISlike : " + list.IsLike);
             }*/

            Management management = new Management();
            Console.WriteLine("Retriving Top three Hightest RatingRecords");
            management.TopRecords(productReviewlist);
            Console.WriteLine("Retriving  Rating for a given Ids");
            management.SelectedRecords(productReviewlist);
            Console.WriteLine("Counting the ids");
            management.CountProductIds(productReviewlist);
            Console.WriteLine("Retriving all productId and review records from the list");
            management.ParticularRows(productReviewlist);
            Console.WriteLine("Skipping the Top 5 records from the list ");
            management.SkipTopRecords(productReviewlist);
        }
    }
}
