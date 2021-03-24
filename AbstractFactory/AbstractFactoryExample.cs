using System;

namespace AbstractFactory
{

    class AbstractFactoryExample
    {
        static void Main(string[] args)
        {
            // Фабрика простеньких HTML-страниц
            IHtmlFactory factory = new SimpleHtmlFactory();
            factory.CreateHead();
            factory.CreateBody();
            factory.CreateFooter();

            // Фабрика Bootstrap HTML-страниц
            factory = new BootstrapHtmlFactory();
            factory.CreateHead();
            factory.CreateBody();
            factory.CreateFooter();

            Console.WriteLine("Hello World!");
        }
    }
}
