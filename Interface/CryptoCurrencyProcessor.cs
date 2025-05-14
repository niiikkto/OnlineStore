using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Interface
{
    internal class CryptoCurrencyProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Обработка криптовалютного платежа на сумму {amount} BTC");
        }

        public void RefundPayment(decimal amount, string transactionId)
        {
            Console.WriteLine($"Возврат криптовалюты на сумму {amount} BTC по транзакции {transactionId}");
        }
    }
}
