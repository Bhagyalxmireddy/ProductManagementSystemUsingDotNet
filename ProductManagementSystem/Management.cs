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
        public Management()
        {
            dataTable.Columns.Add("ProductId", typeof(int));
            dataTable.Columns.Add("UserId", typeof(int));
            dataTable.Columns.Add("Rating", typeof(double));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("IsLike", typeof(bool));


            dataTable.Rows.Add(1, 1, 2, "Good", true);
            dataTable.Rows.Add(2, 2, 4, "Good", true);
            dataTable.Rows.Add(3, 3, 5, "Good", true);
            dataTable.Rows.Add(4, 4, 3, "Bad", false);
            dataTable.Rows.Add(5, 5, 2, "Nice", true);
            dataTable.Rows.Add(6, 6, 1, "bad", true);
            dataTable.Rows.Add(7, 7, 1, "Good", false);
            dataTable.Rows.Add(8, 8, 5, "Nice", true);
            dataTable.Rows.Add(9, 9, 4, "Nice", true);
            dataTable.Rows.Add(10, 10, 5, "Bad", false);
            dataTable.Rows.Add(11, 11, 3, "Nice", true);
            dataTable.Rows.Add(12, 12, 5, "Okay", true);
            dataTable.Rows.Add(13, 13, 4, "Nice", true);
            dataTable.Rows.Add(14, 14, 2, "Bad", false);
            dataTable.Rows.Add(15, 15, 3, "Nice", true);
            dataTable.Rows.Add(16, 16, 3, "Good", true);
            dataTable.Rows.Add(17, 17, 1, "Bad", false);
            dataTable.Rows.Add(18, 18, 1, "Bad", true);
            dataTable.Rows.Add(19, 19, 2, "Good", true);
            dataTable.Rows.Add(20, 20, 5, "Good", true);
            dataTable.Rows.Add(21, 21, 1, "Nice", true);
        }

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
            var recordedData = productReviews.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count()});
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
        public void SkipTopRecords(List<ProductReview> productReviews)
        {
            var records = (from recods in productReviews
                           select (recods)).Skip(5);
            foreach (var list in records)
            {
                Console.WriteLine("ProductId:-" + list.ProductId + "" + "UserId:-" + list.UserId + "" + "Rating: " + list.Rating + "" + "Rivew: " + list.Review + "" +
                    "ISlike : " + list.IsLike);
            }
        }
        public void ProductIdandReviewsFromList(List<ProductReview> productReviews)
        {
            var recordedData = productReviews.Select(x => new { ProductId = x.ProductId, Review = x.Review  });
            foreach (var list in recordedData)
            {
                Console.WriteLine("Product Id: " + list.ProductId + " " + "Review: " + list.Review);
            }
        }
        public void RetrieveRecordsIsLikevalues()
        {
            var data = from review in dataTable.AsEnumerable()
                       where review.Field<bool>("isLike").Equals(true)
                       select review;

            foreach (var dataValue in data)
            {
                Console.WriteLine($"ProductID- {dataValue.ItemArray[0]} UserID- {dataValue.ItemArray[1]} Rating- {dataValue.ItemArray[2]} Review- {dataValue.ItemArray[3]} isLike- {dataValue.ItemArray[4]}");
            }
        }

    }
}
