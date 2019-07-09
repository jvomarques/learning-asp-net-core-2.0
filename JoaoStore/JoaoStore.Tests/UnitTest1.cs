using JoaoStore.Domain.StoreContext;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JoaoStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var customer = new Customer("Joao", "Marques", "12345678", "joao@gmail.com", "123456789", "Rua Austria, 12");
            var order = new Order(customer);
            
        }
    }
}
