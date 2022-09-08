using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Domain
{
    public class Money : IEquatable<Money>
    {
        public decimal Amount { get; set; }
        public Money(decimal amount)
        {
            Amount = amount;
        }

        public bool Equals(Money? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return Amount.Equals(other.Amount);           
            
        }

        // == ve != operatörleri override edilerek daha sexy bir çözüm sunulabilir. 

        public override int GetHashCode() => Amount.GetHashCode();
      
    }
}
