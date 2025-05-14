using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Interface
{
    internal interface IPaymentProcessor
    {
        bool ProcessPayment(decimal amount);
        bool RefundPayment(decimal amount, string transactionId);
    }
}
