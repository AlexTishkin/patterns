using Adapter.AnotherLibrary;
using Adapter.MyLibrary;
using System;

namespace Adapter
{
    class AdapterExample
    {
        /// <summary>
        /// Некий вывод логов
        /// </summary>
        /// <param name="log"></param>
        public static void ShowLog(MyLog log) => Console.WriteLine($"LOG [{log.Date}]: {log.Message}");

        static void Main(string[] args)
        {
            IAnotherLogService anotherService = new AnotherLogService();

            // Попытка вывести лог из чужой библиотеки. Ошибка - несовместимые форматы
            //AnotherLog log = anotherService.GetLog();
            //ShowLog(log);

            // Вывод лога из чужой библиотеки посредством адаптера
            var anotherServiceAdapter = new AnotherLogServiceAdapter(anotherService);
            MyLog myLog = anotherServiceAdapter.GetMyLog();
            ShowLog(myLog);

        }
    }
}
