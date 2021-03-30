using System;

namespace State
{
    public class WaitForCoffeeChooseState : State
    {
        public WaitForCoffeeChooseState(CoffeApparat coffeApparat) : base(coffeApparat) { }

        public override void ChooseCoffee()
        {
            Console.WriteLine("Кофе выбран!");
            Console.WriteLine("Кофе готовится!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Кофе приготовлен!");
            _coffeApparat.ChangeState(new WaitForPaymentState(_coffeApparat));
        }

        public override void Pay()
        {
            // Not implemented
            Console.WriteLine("Деньги уже внесены! Выберите кофе!");
        }
    }
}
