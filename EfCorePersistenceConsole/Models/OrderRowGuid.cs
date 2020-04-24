using System;
using System.Collections.Generic;

namespace EfCorePersistenceConsole.Models
{
    public class OrderRowGuid : ValueObject
    {
        public Guid Value { get; private set; }


        private OrderRowGuid()
        {
        }


        public OrderRowGuid(Guid value)
        {
            if (value == default)
                throw new ArgumentNullException(nameof(value), "Row guid cannot be empty");

            Value = value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}
