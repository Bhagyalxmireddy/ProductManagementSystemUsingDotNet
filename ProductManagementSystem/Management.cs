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
    }
}
