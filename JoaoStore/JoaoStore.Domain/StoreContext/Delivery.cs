using System;

namespace JoaoStore.Domain.StoreContext{
    public class Delivery {
        
        public DateTime createDate { get; set; }    
        public DateTime estimatedDeveliveryDate { get; set; }
        public string status { get; set; }
        
    }
}