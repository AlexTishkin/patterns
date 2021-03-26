using System;

namespace Adapter.MyLibrary
{
    public class MyLogService : IMyLogService
    {
        public MyLog GetMyLog()
        {
            var myLog = new MyLog
            {
                Message = "Произошла ошибка при попытке добавить объект в БД",
                Date = DateTime.Now
            };
            return myLog;
        }
    }
}
