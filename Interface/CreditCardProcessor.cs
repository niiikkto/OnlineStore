using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Interface
{
    internal class CreditCardProcessor : IPaymentProcessor, IPaymentValidator
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Обработка платежа по кредитной карте на сумму {amount} USD");
        }

        public void RefundPayment(decimal amount, string transactionId)
        {
            Console.WriteLine($"Возврат по кредитной карте суммы {amount} USD по транзакции {transactionId}");
        }

        public bool ValidatePayment(decimal amount)
        {
            Console.WriteLine($"Валидация платежа по кредитной карте на сумму {amount} USD");
            return amount > 0 && amount <= 10000;
        }
    }
}

