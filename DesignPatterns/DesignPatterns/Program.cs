using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new InvoiceBuilder();

            var invoice = builder.SetInvoiceNumber("ACF 531")
                                 .SetDate(new DateTime(2021, 10, 24))
                                 .SetVendor("TERG S.A.")
                                 .SetVendee("Artur Oczkowski")
                                 .SetLineItems(new List<string>() { "Item1", "Item2"})
                                 .SetNote("Note about this invnvoice")
                                 .Build();
            Console.WriteLine($"Vendor: {invoice.Vendor}\nVendee: {invoice.Vendee}\nNote: {invoice.Note}\nLineItems: {invoice.LineItems.First()}");
        }
    }
}
