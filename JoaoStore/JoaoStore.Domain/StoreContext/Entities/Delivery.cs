using System;
using JoaoStore.Domain.StoreContext.Enums;

namespace JoaoStore.Domain.StoreContext{
    public class Delivery {
        public Delivery( DateTime estimatedDeveliveryDate)
        {
            this.createDate = DateTime.Now;
            this.estimatedDeveliveryDate = estimatedDeveliveryDate;
            this.status = EDeliveryStatus.waiting;
        }

        public DateTime createDate { get; private set; }    
        public DateTime estimatedDeveliveryDate { get; private set; }
        public EDeliveryStatus status { get; private set; }
        
    }
}