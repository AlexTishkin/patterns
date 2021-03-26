using System;

namespace Strategy
{
    /// <summary>
    /// Монитор для вывода логов
    /// </summary>
    public class LogMonitor
    {
        private ILogMonitorStrategy _strategy;

        public void ShowLog(Log log)
        {
            if (_strategy == null)
                throw new NullReferenceException("Выберите стратегию для вывода логов (SetStrategy)");

            _strategy.ShowLog(log);
        }


        /// <summary>
        /// Устанавливает стратегию.
        /// </summary>
        /// <param name="strategy"></param>
        public void SetStrategy(ILogMonitorStrategy strategy)
        {
            _strategy = strategy;
        }
    }
}
