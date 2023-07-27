using Domain.Customers;
using Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Orders
{
    public class Order
    {

        private readonly HashSet<LineItem> _lineitems = new();
        private Order()
        {
        }

        public Order(Customer customer)
        {
            var Order = new Order();
        }

        public Guid Id { get; private set; }
        public Guid CustomerId { get; private set; }

        public void Add(Product product)
        {
            //importante fare uno snapshot del prodotto con quel prezzo in questo istante e salvarlo così
            //perche nel tempo puo cambiare ma la momento dell'acquisto deve rimanere immutabile
            var lineItem = new LineItem(Guid.NewGuid(), Id, product.Id, product.Price);
            _lineitems.Add(lineItem);
        }
    }


}
