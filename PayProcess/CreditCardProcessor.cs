using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Interface
{
    internal class CreditCardProcessor : IPaymentProcessor, IPaymentValidator
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Обработка кредитной карты на сумму {amount}");
            return true;
        }

        public bool RefundPayment(decimal amount, string transactionId)
        {
            Console.WriteLine($"Возврат по кредитной карте {transactionId} на сумму {amount}");
            return true;
        }

        public bool ValidatePayment(decimal amount)
        {
            Console.WriteLine($"Валидация кредитной карты для суммы {amount}");
            return amount > 0 && amount <= 10000;
        }
    }
}
