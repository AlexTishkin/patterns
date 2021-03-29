using System.Linq;

namespace Bridge
{
    public class CoeffMathManager : IMathManager
    {
        private double _coefficient;

        public CoeffMathManager(double coefficient)
        {
            _coefficient = coefficient;
        }

        public double Add(double[] values) => values.Sum() * _coefficient;

        public double Multiple(double[] values) => values.Aggregate((a, b) => a * b) * _coefficient;
    }
}
