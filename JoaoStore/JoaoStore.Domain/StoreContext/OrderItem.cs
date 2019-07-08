using System;

namespace JoaoStore.Domain.StoreContext{
    public class OrderItem {

        public Product product { get; set; }
        public string quantity { get; set; }    
        public string price { get; set; }
    }
}