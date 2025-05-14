using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Interface
{
    internal class PaymentHandler
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
            processor.ProcessPayment(amount);
        }
    }
}
