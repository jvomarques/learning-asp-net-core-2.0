using System;

namespace JoaoStore.Domain.StoreContext{
    public class OrderItem {
        public OrderItem(Product product, decimal quantity)
        {
            this.product = product;
            this.quantity = quantity;
            this.price = product.price;
        }

        public Product product { get; private set; }
        public decimal quantity { get; private set; }    
        public decimal price { get; private set; }
    }
}