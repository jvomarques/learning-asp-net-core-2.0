using System;

namespace JoaoStore.Domain.StoreContext{
    public class Customer {
        public Customer(string firstName, string lastName, string document, string email, string phone, string address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.document = document;
            this.email = email;
            this.phone = phone;
            this.address = address;
        }
        public string firstName { get; private set; }
        public string lastName {get; private set;}
        public string document { get; private set; } 
        public string email { get; private set; }
        public string phone { get; private set; }
        public string address { get; private set; }

        public override string ToString(){
            return $"{firstName} {lastName}";
        }
    }
}