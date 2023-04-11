using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richard_Pizzaria_UML2
{
    public class Customer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public int customerPhone { get; set; }
        public int customerAge { get; set; }

        public override string ToString()
        {
            return $" - Id: {customerId} - Navn: {customerName} - Phone number: {customerPhone} - Age: {customerAge}\n";
        }
    }
}
