using System;
using System.Text;
using Solid.O.Libraries;
using Solid.O.Libraries.Currencies;

namespace Solid.O.ConsoleApplication {
    public static class ConsoleApplication {
        private static ICurrency _currency;

        public static void Main() {
            Console.OutputEncoding = Encoding.UTF8;
            PrintUsingDynamicPolymorphism();
            PrintUsingStaticPolymorphism();
        }

        private static void PrintUsingStaticPolymorphism() {
            Console.WriteLine("Printing using static polymorphism:\n");
            CurrencyPrinter.PrintCurrency<Euro>();
            CurrencyPrinter.PrintCurrency<PoundSterling>();
            CurrencyPrinter.PrintCurrency<UsDollar>();
        }

        private static void PrintUsingDynamicPolymorphism() {
            Console.WriteLine("Printing using Dynamic Polymorphism\n");
            _currency = new Euro();
            CurrencyPrinter.PrintCurrency(_currency);
            _currency = new PoundSterling();
            CurrencyPrinter.PrintCurrency(_currency);
            _currency = new UsDollar();
            CurrencyPrinter.PrintCurrency(_currency);
        }
    }
}