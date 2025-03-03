using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15.Entities
{
    partial class Reservation
    {
        public override string ToString()
            => $"{Id} | {FullName} | {PhoneNumber}";
    }
}
