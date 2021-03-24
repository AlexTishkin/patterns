using System;

namespace Builder
{
    class BuilderExample
    {
        static void Main(string[] args)
        {
            IBuilder builder = new SimpleHtmlBuilder();
            builder.BuildHead();
            builder.BuildBody();
            builder.BuildFooter();

            var simpleHtml = builder.GetResult();
            Console.WriteLine(simpleHtml);
        }
    }
}
