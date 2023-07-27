using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products
{

    public record Sku
    {
        private const int DefaultLenght = 15;
        private Sku(string value) => Value = value;

        //lo voglio immutable; init significa che una volta inzializzato no lo si può cambiare
        public string Value { get; init; }

        public static Sku? Create(string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;
            if (value.Length != DefaultLenght)
                return null;

            return new Sku(value);
        }
    }
}
