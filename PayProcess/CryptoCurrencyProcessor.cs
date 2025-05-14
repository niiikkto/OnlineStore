using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Interface
{
    internal class CryptoCurrencyProcessor : IPaymentProcessor
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Обработка криптовалютного платежа на сумму {amount}");
            return true;
        }

        public bool RefundPayment(decimal amount, string transactionId)
        {
            Console.WriteLine($"Возврат криптовалютного платежа {transactionId} на сумму {amount}");
            return true;
        }
    }
}
