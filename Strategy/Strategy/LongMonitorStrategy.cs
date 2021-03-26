using System;

namespace Strategy
{
    /// <summary>
    /// Вывод лога в длинном формате
    /// </summary>
    public class LongMonitorStrategy : ILogMonitorStrategy
    {
        public void ShowLog(Log log)
        {
            var longLog = $"[{log.DateTime}]: ID: [{log.Id}]; LEVEL: {log.Level}; MESSAGE: {log.Text}; DATE: {log.DateTime}";
            Console.WriteLine(longLog);
        }
    }
}
