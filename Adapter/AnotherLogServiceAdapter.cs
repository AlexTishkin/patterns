using Adapter.AnotherLibrary;
using Adapter.MyLibrary;

namespace Adapter
{
    /// <summary>
    /// Паттерн "Адаптер".
    /// https://refactoring.guru/ru/design-patterns/adapter
    /// Вариант применения - преобразование логов с другой библиотеки к нашей
    /// </summary>
    public class AnotherLogServiceAdapter : IMyLogService
    {
        private IAnotherLogService _anotherService;

        public AnotherLogServiceAdapter(IAnotherLogService anotherService)
        {
            _anotherService = anotherService;
        }

        public MyLog GetMyLog()
        {
            AnotherLog anotherLog = _anotherService.GetLog();
            MyLog myLog = new MyLog
            {
                Date = anotherLog.Date,
                Message = $"(from AnotherService), ID: {anotherLog.Id}, LVL: {anotherLog.Level}, {anotherLog.Text}"
            };
            return myLog;
        }
    }
}
