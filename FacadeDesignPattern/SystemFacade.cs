using FacadeDesignPattern.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    public class SystemFacade
    {
        private readonly IInventoryService _inventoryService;
        private IPaymentService _paymentService;
        private readonly IShippingService _shippingService;
        private readonly ILogger<SystemFacade> _logger;

        public SystemFacade(IInventoryService inventoryService, IPaymentService paymentService, IShippingService shippingService , ILogger<SystemFacade> logger)
        {
            _inventoryService = inventoryService;
            _paymentService = paymentService;
            _shippingService = shippingService;
            _logger = logger;
        }

        public void ProcessOrder(string productCode, int quantity, string paymentType, decimal amount)
        {
            _logger.LogInformation("Processing order for {Product} with quantity {Quantity}", productCode, quantity);
            if (_inventoryService.IsInStock(productCode, quantity))
            {
                if (_paymentService.ProcessPayment(paymentType, amount))
                {
                    string message = $"Processed payment of {amount} via {paymentType}";
                    Console.WriteLine(message);
                    _shippingService.ProcessShipping();
                    _logger.LogInformation("Order processed successfully");
                }
                else
                {
                    Console.WriteLine("Payment failed");
                }
            }
            else
            {
                Console.WriteLine("Product is out of stock");
            }
        }
    }
}
