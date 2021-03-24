using System;

namespace Prototype
{
    /// <summary>
    /// Реализация паттерна "Прототип"
    /// https://refactoring.guru/design-patterns/prototype
    /// Вариант применения - копирование объекта "Студент" (человек)
    /// </summary>
    class PrototypeExample
    {
        static void Main(string[] args)
        {
            Student student1 = new Student { StudentId = 100205, Name = "Иванов Иван Иванович", Age = 19, Course = 1 };
            Student student2 = (Student)student1.Clone();

            Console.WriteLine(student1);
            Console.WriteLine(student2);
        }
    }
}
