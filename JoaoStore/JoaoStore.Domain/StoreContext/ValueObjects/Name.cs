using System;

namespace JoaoStore.Domain.StoreContext.ValueOjects{
    public class Name {
        public Name(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string firstName { get; private set; }
        public string lastName { get; private set; }

        public override string ToString(){
            return $"{firstName} {lastName}";
        }
    }
}