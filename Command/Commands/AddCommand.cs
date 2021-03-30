using System;

namespace Command
{
    public class AddCommand : Command
    {
        private double _a, _b;

        public AddCommand(Receiver receiver, double a, double b) : base(receiver)
        {
            _a = a;
            _b = b;
        }

        public override void Execute()
        {
            var result = _receiver.Add(_a, _b);
            Console.WriteLine($"{_a} + {_b} = {result}");
        }
    }
}
