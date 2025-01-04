using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.Services
{
    internal class InventoryService : IInventoryService
    {
        public bool IsInStock(string productCode, int quantity)
        {
            var product =  ProductService.GetProducts().FirstOrDefault(p => p.Code == productCode && p.Quantity >= quantity);
            return product != null;
        }
    }

    public interface IInventoryService
    {
        bool IsInStock(string productCode, int quantity);
    }
}
