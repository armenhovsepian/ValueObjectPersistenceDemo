using System;
using System.Collections.Generic;

namespace EfCorePersistenceConsole.Models
{
    public class OrderDate : ValueObject
    {
        public DateTime Value { get; set; }

        public OrderDate()
        {
        }

        public OrderDate(DateTime value)
        {
            if (value == default)
                throw new ArgumentNullException(nameof(value), "Order date cannot be empty");

            Value = value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
