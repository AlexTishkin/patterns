using System.Linq;

namespace Bridge
{
    public class SimpleMathManager : IMathManager
    {
        public double Add(double[] values) => values.Sum();

        public double Multiple(double[] values) => values.Aggregate((a, b) => a * b);
    }
}
