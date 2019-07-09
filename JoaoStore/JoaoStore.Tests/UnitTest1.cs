using JoaoStore.Domain.StoreContext;
using JoaoStore.Domain.StoreContext.ValueOjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JoaoStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {   
            var name = new Name("Joao", "Marques");
            var document = new Document("12345678");
            var email = new Email("joao@gmail.com");
            var customer = new Customer(name, document, email, "123456789", "Rua Austria, 12");
            var order = new Order(customer);

        }
    }
}
