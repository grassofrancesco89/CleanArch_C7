using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products
{
    //in DDD when you have an object that is only identifible by vallue we call that a VALUE OBJECT (VO)
    //Two VO to be equal they need to have the same value (not for two object entities)
    //RECORD are immutable by design
    public record Money(string Currency, decimal Amount);
}
