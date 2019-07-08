using System;
using System.Collections.Generic;

namespace JoaoStore.Domain.StoreContext{
    public class Order {

        public Customer customer { get; set; }
        public string number { get; set; }
        public DateTime createDate { get; set; }
        public string status { get; set; }
        public IList<OrderItem> items { get; set; }
        public IList<Delivery> deliveries { get; set; }

        //Do order
        public void placeOrder(){

        }
        
    }
}