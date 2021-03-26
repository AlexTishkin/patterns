using System;

namespace Strategy
{
    /// <summary>
    /// Вывод лога в коротком формате
    /// </summary>
    public class ShortMonitorStrategy : ILogMonitorStrategy
    {
        public void ShowLog(Log log)
        {
            var shortLog = $"[{log.DateTime}]: {log.Text}";
            Console.WriteLine(shortLog);
        }
    }
}
