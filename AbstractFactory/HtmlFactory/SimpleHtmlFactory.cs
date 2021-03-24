namespace AbstractFactory
{
    /// <summary>
    /// Генерация простенькой HTML-страницы
    /// </summary>
    public class SimpleHtmlFactory : IHtmlFactory
    {
        public string CreateHead()
        {
            return "<html><head></head>";
        }

        public string CreateBody()
        {
            return "<body>Simple page</body>";
        }

        public string CreateFooter()
        {
            return "</html>";
        }

    }
}
