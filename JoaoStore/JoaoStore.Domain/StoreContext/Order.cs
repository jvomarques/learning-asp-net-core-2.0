using System;
using System.Collections.Generic;
using JoaoStore.Domain.StoreContext.Enums;

namespace JoaoStore.Domain.StoreContext{
    public class Order {
        public Order(Customer customer)
        {
            this.customer = customer;
            this.number = Guid.NewGuid().ToString().Replace("-", "").Substring(0,8).ToUpper();
            this.createDate = DateTime.Now;
            this.status = EOrderStatus.created;
            this.items = new List<OrderItem>();
            this.deliveries = new List<Delivery>();
        }

        public Customer customer { get; private set; }
        public string number { get; private set; }
        public DateTime createDate { get; private set; }
        public EOrderStatus status { get; private set; }
        public IReadOnlyCollection<OrderItem> items { get; private set; }
        public IReadOnlyCollection<Delivery> deliveries { get; private set; }

        public void addItem(OrderItem item){

        }
        //Do order
        public void placeOrder(){

        }
        
    }
}