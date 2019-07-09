using System;

namespace JoaoStore.Domain.StoreContext.ValueOjects{
    public class Email {
        public Email(string address)
        {
            this.address = address;
        }

        public string address { get; private set; }

        public override string ToString(){
            return this.address;
        }
    }
}