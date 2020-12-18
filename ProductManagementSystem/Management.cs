using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductManagementSystem
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();

        public void TopRecords(List<ProductReview> reviews)
        {
            var recordedData = (from Productreviews in reviews
                                orderby Productreviews.Rating descending
                                select Productreviews).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + "" + "UserId:-" + list.UserId + "" + "Rating: " + list.Rating + "" + "Rivew: " + list.Review + "" +
                     "ISlike : " + list.IsLike);
            }
        }
        public void SelectedRecords(List<ProductReview> listproductrivews)
        {
            var rescordedData = from productreviews in listproductrivews
                                where (productreviews.ProductId == 1 || productreviews.ProductId == 4 || productreviews.ProductId == 9) &&
                                (productreviews.Rating > 3)
                                select productreviews;


            /*(productreviews.ProductId == 1 && productreviews.Rating > 3) ||
            (productreviews.ProductId == 4 && productreviews.Rating > 3) ||
            (productreviews.ProductId == 9 && productreviews.Rating > 3)
            select productreviews;*/
            foreach (var list in rescordedData)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + "" + "UserId:-" + list.UserId + "" + "Rating: " + list.Rating + "" + "Rivew: " + list.Review + "" +
                     "ISlike : " + list.IsLike);
            }
        }
        public void CountProductIds(List<ProductReview> productReviews)
        {
            var recordedData = productReviews.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine("Product Id: " + list.ProductId + " " + "Count: " + list.Count);
            }
        }
        public void ParticularRows(List<ProductReview> productReviews)
        {
            var records = from list in productReviews
                          select (list.ProductId, list.Review);
            foreach(var list in records)
            {
                Console.WriteLine("Product Id: " + list.ProductId + "  " + "Reviews : " + list.Review);
            }
        }
    }
}
