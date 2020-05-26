using System.Collections.Generic;

namespace EFCoreSeparateProject.Core.Domain
{
    public class Customer : Entity
    {
        public Customer()
        {
            _customerOrders = new List<Order>();
        }

        public string FirstName { get; private set; }
        public string LastName { get;  private set; }
        public Address Address { get; private set; }
        public void AddAddress(string line1, string line2, string postcode)
        {
            Address = new Address(line1, line2, postcode);
        }

        private List<Order> _customerOrders;
        public IReadOnlyList<Order> CustomerOrders => _customerOrders.AsReadOnly();
    }
}
