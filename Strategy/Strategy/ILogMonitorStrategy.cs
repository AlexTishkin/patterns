namespace Strategy
{
    /// <summary>
    /// Стратегия вывода алгоритма на монитор.
    /// </summary>
    public interface ILogMonitorStrategy
    {
        void ShowLog(Log log);
    }
}