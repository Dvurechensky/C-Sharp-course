namespace Lesson_68___partial_класс__частичные_типы__partial_методы
{
    partial class Person
    {
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void PrintFullName()//partial
        {
            System.Console.WriteLine(GetFullName());
        }
    }
}
