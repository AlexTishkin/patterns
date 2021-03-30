using System;

namespace Command
{
    public class SubCommand : Command
    {
        private double _a, _b;

        public SubCommand(Receiver receiver, double a, double b) : base(receiver)
        {
            _a = a;
            _b = b;
        }

        public override void Execute()
        {
            var result = _receiver.Sub(_a, _b);
            Console.WriteLine($"{_a} - {_b} = {result}");
        }
    }
}
