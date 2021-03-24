namespace Builder
{
    public class SimpleHtmlBuilder : IBuilder
    {
        private string result;

        public SimpleHtmlBuilder()
        {
            result = string.Empty;
        }

        public void BuildHead()
        {
            result += "<html><head></head>";
        }

        public void BuildBody()
        {
            result += "<body></body>";
        }

        public void BuildFooter()
        {
            result += "</html>";
        }


        public void Reset()
        {
            result = string.Empty;
        }

        public string GetResult() => result;
    }
}
