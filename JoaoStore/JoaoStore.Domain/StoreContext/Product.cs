using System;

namespace JoaoStore.Domain.StoreContext{
    public class Product {

        public string title { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string price { get; set; }
        public string quantityOnHand { get; set; }
        
    }
}