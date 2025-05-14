using PaymentSystem.Processors;
using PaymentSystem.Services;
using System;

namespace PaymentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем сервис для работы с платежами
            var paymentService = new PaymentService();

            // Пример PayPal платежа
            var payPalProcessor = new PayPalProcessor();
            paymentService.ProcessPayment(payPalProcessor, 100.50m);

            // Пример платежа по кредитной карте (с валидацией)
            var creditCardProcessor = new CreditCardProcessor();
            paymentService.ProcessPayment(creditCardProcessor, 200.75m);

            // Пример криптовалютного платежа
            var cryptoProcessor = new CryptoCurrencyProcessor();
            paymentService.ProcessPayment(cryptoProcessor, 50.25m);

            // Пример возврата платежа
            paymentService.RefundPayment(creditCardProcessor, 100.00m, "TXN12345");
        }
    }
}