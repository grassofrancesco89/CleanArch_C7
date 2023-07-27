using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customers
{
    //set to private becouse we dont want the entity to be changed outside the scope  of the customer class
    //if we want to change the name or email we'll do that expososing some method on our entity that the application layer can call an apply
    public class Customer
    {
        public Guid Id { get; private set; }
        public string Email { get; private set; } = string.Empty; 
        public string Name { get; private set;} = string.Empty;

    }
}
