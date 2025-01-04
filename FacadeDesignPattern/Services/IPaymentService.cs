using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.Services
{
    internal class PaymentService : IPaymentService
    {
        public bool ProcessPayment(string paymentType, decimal amount)
        {
        
            return true;
        }
    }

    public interface IPaymentService
    {
        bool ProcessPayment(string paymentType, decimal amount);
    }
}
