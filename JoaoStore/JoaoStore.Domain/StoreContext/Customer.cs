using System;
using JoaoStore.Domain.StoreContext.ValueOjects;

namespace JoaoStore.Domain.StoreContext{
    public class Customer {
        public Customer(Name name, Document document, Email email, string phone, string address)
        {
            this.name = name;
            this.document = document;
            this.email = email;
            this.phone = phone;
            this.address = address;
        }

        public Name name { get; private set; }
        public Document document { get; private set; } 
        public Email email { get; private set; }
        public string phone { get; private set; }
        public string address { get; private set; }

        public override string ToString(){
            return this.name.ToString();
        }
    }
}