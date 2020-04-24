using System;
using System.Collections.Generic;

namespace EfCorePersistenceConsole.Models
{
    public class OrderAmount : ValueObject
    {
        public decimal Value { get; set; }
        private OrderAmount()
        {
        }


        public OrderAmount(decimal value)
        {
            if (value <= 0)
                throw new ArgumentException("Amount must be greater than zero", nameof(value));

            Value = value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
