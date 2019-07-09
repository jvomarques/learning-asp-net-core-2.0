using System;
using System.Collections.Generic;
using System.Linq;
using JoaoStore.Domain.StoreContext.ValueOjects;

namespace JoaoStore.Domain.StoreContext{
    public class Customer {

        private readonly IList<Address> _addresses;
        public Customer(Name name, Document document, Email email, string phone)
        {
            this.name = name;
            this.document = document;
            this.email = email;
            this.phone = phone;
            this._addresses = new List<Address>();
        }

        public Name name { get; private set; }
        public Document document { get; private set; } 
        public Email email { get; private set; }
        public string phone { get; private set; }
        public IReadOnlyCollection<Address> addresses => this._addresses.ToArray();

        public void addAddress(Address address){
            this._addresses.Add(address);
        }
        public override string ToString(){
            return this.name.ToString();
        }
    }
}