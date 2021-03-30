namespace Command
{
    /// <summary>
    /// Получатель хранит бизнес-логику
    /// </summary>
    public class Receiver
    {
        public double Add(double a, double b) => a + b;
        public double Sub(double a, double b) => a - b;
        public double Multiple(double a, double b) => a * b;
        public double Div(double a, double b) => a / b;
    }
}
