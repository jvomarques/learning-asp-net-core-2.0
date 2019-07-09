using System;

namespace JoaoStore.Domain.StoreContext{
    public class Product {
        public Product(string title, string description, string image, decimal price, decimal quantityOnHand)
        {
            this.title = title;
            this.description = description;
            this.image = image;
            this.price = price;
            this.quantityOnHand = quantityOnHand;
        }

        public string title { get; private set; }
        public string description { get; private set; }
        public string image { get; private set; }
        public decimal price { get; private set; }
        public decimal quantityOnHand { get; private set; }
        
        public override string ToString(){
            return title;
        }
    }
}