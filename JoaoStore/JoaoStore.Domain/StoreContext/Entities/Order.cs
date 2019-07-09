using System;
using System.Collections.Generic;
using System.Linq;
using JoaoStore.Domain.StoreContext.Enums;

namespace JoaoStore.Domain.StoreContext{
    public class Order {

        private readonly IList<OrderItem> _items;
        private readonly IList<Delivery> _deliveries;

        public Order(Customer customer)
        {
            this.customer = customer;
            this.number = Guid.NewGuid().ToString().Replace("-", "").Substring(0,8).ToUpper();
            this.createDate = DateTime.Now;
            this.status = EOrderStatus.created;
            this._items = new List<OrderItem>();
            this._deliveries = new List<Delivery>();
        }

        public Customer customer { get; private set; }
        public string number { get; private set; }
        public DateTime createDate { get; private set; }
        public EOrderStatus status { get; private set; }
        public IReadOnlyCollection<OrderItem> items => _items.ToArray();
        public IReadOnlyCollection<Delivery> deliveries => _deliveries.ToArray();

        public void addItem(OrderItem item){
            this._items.Add(item);
        }

        public void addDelivery(Delivery delivery){
            this._deliveries.Add(delivery);
        }
        //Do order
        public void placeOrder(){

        }
        
    }
}