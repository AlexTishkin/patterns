namespace TemplateMethod
{
    /// <summary>
    /// Паттерн "Шаблонный метод".
    /// https://refactoring.guru/ru/design-patterns/template-method
    /// Вариант применения - избавление от дублирования кода при работе с единым алгоритмом
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var vkAnalyzer = new VKAnalyzer();
            var okAnalyzer = new OKAnalyzer();

            vkAnalyzer.SingleParse("https://vk.com/id123456789");
            okAnalyzer.SingleParse("https://ok.com/id123456789");
        }
    }
}
