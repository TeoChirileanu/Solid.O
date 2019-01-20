using Solid.O.Libraries;

namespace Solid.O.ConsoleApplication {
    internal static class ConsoleApplication {
        private static readonly IGetter Getter = new ConsoleGetter();
        private static readonly IDeliverer Deliverer = new ConsoleDeliverer();

        private static void Main() {
            var message = Getter.Get();
            Deliverer.Deliver(message);
        }
    }
}