using System;

namespace Command
{
    public class MultipleCommand : Command
    {
        private double _a, _b;

        public MultipleCommand(Receiver receiver, double a, double b) : base(receiver)
        {
            _a = a;
            _b = b;
        }

        public override void Execute()
        {
            var result = _receiver.Multiple(_a, _b);
            Console.WriteLine($"{_a} * {_b} = {result}");
        }
    }
}
