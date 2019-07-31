using System;
namespace TaskHandler
{
    public class Product
    {
        public String Name { get; set; }
        public DateTime Expiry { get; set; }
        public String[] Sizes { get; set; }

        public Product()
        {

        }
        //Product product = new Product();
        //product.Name = "Apple";
        //product.Expiry = new DateTime(2008, 12, 28);
        //product.Sizes = new string[] { "Small" };
}
}
