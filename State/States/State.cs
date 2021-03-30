namespace State
{
    /// <summary>
    /// Состояние кофемашины
    /// 1. Ожидание внесения денег
    /// 2. Ожидание выбора кофе
    /// 3. Приготовление кофе
    /// 1 -> 2 -> 3 -> 1
    /// </summary>
    public abstract class State
    {
        protected CoffeApparat _coffeApparat;

        public State(CoffeApparat coffeApparat)
        {
            _coffeApparat = coffeApparat;
        }

        /// <summary>
        /// Внести деньги
        /// </summary>
        public abstract void Pay();

        /// <summary>
        /// Выбрать кофе
        /// </summary>
        public abstract void ChooseCoffee();
    }
}
