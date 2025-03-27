using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment5
{
    public class Customer : IEquatable<Customer>
    {
        public string Name { get; }
        public string Contact { get; }   //顾客联系方式

        public Customer(string name, string contact)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Contact = contact ?? throw new ArgumentNullException(nameof(contact));
        }

        public bool Equals(Customer other) =>
            Name == other?.Name && Contact == other.Contact;

        public override string ToString() => $"{Name} ({Contact})";
    }

    
}
