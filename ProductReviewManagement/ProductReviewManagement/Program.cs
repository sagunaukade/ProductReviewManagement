using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Review Management using LINQ");
            Console.WriteLine("Adding a Prodcut Review In list");
            Console.WriteLine("Enter Option");
            int Choice = Convert.ToInt32(Console.ReadLine());
            //Creating a list for Product Review
            List<ProductReview> productReviews = new List<ProductReview>();
            switch (Choice)
            {
                case 1:
                    ProductReviewManager.AddingProductReview(productReviews);
                    break;
            }
            Console.ReadLine();
        }
    }
}
