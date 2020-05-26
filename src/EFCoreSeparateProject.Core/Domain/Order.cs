using System;

namespace EFCoreSeparateProject.Core.Domain
{
    public class Order : Entity
    {
        public Order(DateTime orderDate)
        {
            OrderDate = orderDate;
        }
        public DateTime OrderDate { get; private set; }
    }
}
