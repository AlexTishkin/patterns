namespace Bridge
{
    /// <summary>
    /// Интерфейс управления (абстракция)
    /// </summary>
    public class Api
    {
        private IMathManager _mathManager;

        public Api(IMathManager mathManager)
        {
            _mathManager = mathManager;
        }

        public double Sum(double a, double b)
        {
            var result = _mathManager.Add(new double[] { a, b });
            return result;
        }

        public double Multiple(double a, double b)
        {
            var result = _mathManager.Multiple(new double[] { a, b });
            return result;
        }

    }
}
