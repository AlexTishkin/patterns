namespace State
{
    /// <summary>
    /// Кофемашина
    /// </summary>
    public class CoffeApparat
    {
        private State _state;

        public CoffeApparat()
        {
            _state = new WaitForPaymentState(this);
        }

        public void ChangeState(State state)
        {
            _state = state;
        }

        public void Pay() => _state.Pay();

        public void ChooseCoffee() => _state.ChooseCoffee();
    }
}
