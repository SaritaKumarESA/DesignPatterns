using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.Services
{
    internal class ShippingService : IShippingService
    {
        public void ProcessShipping()
        {
            Console.WriteLine("Processing shipping");
        }
    }

    public interface IShippingService
    {
       void  ProcessShipping();
    }
}
