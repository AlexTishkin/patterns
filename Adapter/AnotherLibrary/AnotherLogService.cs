using System;

namespace Adapter.AnotherLibrary
{
    public class AnotherLogService : IAnotherLogService
    {
        public AnotherLog GetLog()
        {
            var log = new AnotherLog
            {
                Id = 1,
                Date = DateTime.Now,
                Level = "WARNING",
                Text = "Ошибка при чтении файла"
            };
            return log;
        }
    }
}
