using System;

namespace Strategy
{
    /// <summary>
    /// Лог
    /// </summary>
    public class Log
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string Level { get; set; }
        public DateTime? DateTime { get; set; }

        public Log(Guid id, string text, string level = null, DateTime? dateTime = null)
        {
            Id = id;
            Text = text;
            Level = level;
            DateTime = dateTime;
        }
    }
}
