using System;

namespace State
{
    public class WaitForPaymentState : State
    {
        public WaitForPaymentState(CoffeApparat coffeApparat) : base(coffeApparat) { }

        public override void Pay()
        {
            Console.WriteLine("Внесены деньги. Выберите кофе!");
            _coffeApparat.ChangeState(new WaitForCoffeeChooseState(_coffeApparat));
        }

        public override void ChooseCoffee()
        {
            // Not implemented
            Console.WriteLine("Сначала внесите деньги! После выберите кофе!");
        }
    }
}
