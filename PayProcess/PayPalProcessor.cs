using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Interface
{
    internal class PayPalProcessor : IPaymentProcessor
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Обработка PayPal платежа на сумму {amount}");
            return true;
        }

        public bool RefundPayment(decimal amount, string transactionId)
        {
            Console.WriteLine($"Возврат PayPal платежа {transactionId} на сумму {amount}");
            return true;
        }
    }
}
