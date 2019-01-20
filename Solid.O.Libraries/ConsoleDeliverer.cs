using System;

namespace Solid.O.Libraries {
    public class ConsoleDeliverer : IDeliverer {
        public void Deliver(string message) => Console.WriteLine(message);
    }
}