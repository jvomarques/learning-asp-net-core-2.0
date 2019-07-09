using System;

namespace JoaoStore.Domain.StoreContext.ValueOjects{
    public class Document {
        public Document(string number)
        {
            this.number = number;
        }

        public string number { get; private set; }

        public override string ToString(){
            return this.number;
        }
    }
}