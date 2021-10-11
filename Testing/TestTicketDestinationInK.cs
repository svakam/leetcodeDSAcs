using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcodeDSAcs.Medium.ArraysStrings;

namespace Testing
{
    [TestClass]
    public class TestTicketDestinationInK
    {
        [TestMethod]
        public void TestTicketDestination()
        {
            Ticket[] list = new Ticket[] { new Ticket("SEA", "BULG"), new Ticket("BULG", "DUBAI"), new Ticket("SEA", "SLC"), 
                new Ticket("SLC", "LAX"), new Ticket("SEA", "SLC"), new Ticket("SLC", "SEA") };
            Assert.IsTrue(TicketsDestinationInK.Run("BULG", "DUBAI", list, 1));
            Assert.IsTrue(TicketsDestinationInK.Run("SLC", "DUBAI", list, 3));
            Assert.IsTrue(TicketsDestinationInK.Run("SEA", "LAX", list, 4));
            Assert.IsFalse(TicketsDestinationInK.Run("SEA", "SLC", list, 3));
        }
    }
}
