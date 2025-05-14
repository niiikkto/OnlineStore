using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentSystem.Processors;

namespace ConsoleApp8.Interface
{
    internal class PaymentService
    {
        public void ProcessPayment(IPaymentProcessor processor, decimal amount)
        {
            if (processor is IPaymentValidator validator)
            {
                if (!validator.ValidatePayment(amount))
                {
                    Console.WriteLine("Платеж не прошел валидацию!");
                    return;
                }
            }

            bool result = processor.ProcessPayment(amount);
            Console.WriteLine(result ? "Платеж успешно обработан!" : "Ошибка обработки платежа");
        }

        public void RefundPayment(IPaymentProcessor processor, decimal amount, string transactionId)
        {
            bool result = processor.RefundPayment(amount, transactionId);
            Console.WriteLine(result ? "Возврат успешно обработан!" : "Ошибка обработки возврата");
        }
    }
}
