using System;
using JoaoStore.Domain.StoreContext.Enums;

namespace JoaoStore.Domain.StoreContext{
    public class Address {
        public Address(string street, string number, string complement, string district, string city, string state, string country, string zipCode, EAddressType addressType)
        {
            this.street = street;
            this.number = number;
            this.complement = complement;
            this.district = district;
            this.city = city;
            this.state = state;
            this.country = country;
            this.zipCode = zipCode;
            this.addressType = addressType;
        }

        public string street { get; set; }
        public string number { get; set; }
        public string complement { get; set; }
        public string district { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zipCode { get; set; }
        public EAddressType addressType { get; set; }
        

        public override string ToString(){
            return $"{this.street}, {this.number} - {this.city}/{this.state}";
        }
    }
}