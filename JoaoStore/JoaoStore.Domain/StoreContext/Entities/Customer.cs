using System;
using System.Collections.Generic;
using JoaoStore.Domain.StoreContext.ValueOjects;

namespace JoaoStore.Domain.StoreContext{
    public class Customer {
        public Customer(Name name, Document document, Email email, string phone)
        {
            this.name = name;
            this.document = document;
            this.email = email;
            this.phone = phone;
            this.addresses = new List<Address>();;
        }

        public Name name { get; private set; }
        public Document document { get; private set; } 
        public Email email { get; private set; }
        public string phone { get; private set; }
        public IReadOnlyCollection<Address> addresses { get; private set; }

        public override string ToString(){
            return this.name.ToString();
        }
    }
}