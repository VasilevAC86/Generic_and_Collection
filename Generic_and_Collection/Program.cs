using System.Collections;
using System.Globalization; // Пространство имён с коллекциями

namespace Generic_and_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------------ Коллекции -----------------------------------
            /*List<string> list = new List<string>(); // Динамический массив, как vector в С++
            Stack<string> stack = new Stack<string>(); // первый вошёл, последний вышел, первую тарелку в стеке вымоют последней
            Queue<string> queue = new Queue<string>(); // первый вошёл, первый вышел (как очередь в поликлинике)
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>(); // Пара ключ-значение
            ArrayList arrayList = new ArrayList(); // Динамический массив для хранения в себе любых типов
            HashSet<string> keys = new HashSet<string>(); // Хранение уникальных элементов
            // Методы для list
            list.Add("asd"); // Добавление элементов в список
            list.Remove("list"); // Удаляет по значению первое вхождение элемента
            list.Contains("list"); // Ищет вхождение элемента (true/false)
            list.Clear(); // Полностью очищает список
            int c = list.Count; // Кол-во элементов в списке (как Length/Size в C++)
            // Методы для dictionary
            keyValuePairs.Clear(); // Полснотью чистим
            int b = keyValuePairs.Count; // Кол-во элементов в списке (как Length/Size в C++)
            keyValuePairs.Add(1, "Alise"); // Первая переменная (1) - уникальный ключ
            keyValuePairs.Remove(1); // Удаление по ключу. Можно удалить конкретного "Петю"
            keyValuePairs.ContainsKey(1); // Проверяет, есть ли такой ключ (true/false)
            // Методы HashSet такие же, как и у списка
            keys.Add("asd"); // Добавление элементов в список
            keys.Remove("list"); // Удаляет по значению первое вхождение элемента
            keys.Contains("list"); // Ищет вхождение элемента (true/false)
            keys.Clear(); // Полностью очищает список
            int c2 = list.Count; // Кол-во элементов в списке (как Length/Size в C++)

            Dictionary<string, string> RusToEng = new Dictionary<string, string>()
            {
                {"Россия", "Russia" },
                {"США", "USA" },
                {"Франция", "France" }
            };
            Dictionary<string, string> EngToRus = new Dictionary<string, string>()
            {
                {"Russia", "Россия"},
                {"USA", "США"},
                {"France", "Франция"}
            };
            Console.WriteLine("Выберите направление перевода: ");
            Console.WriteLine("1. Английский -> Русский");
            Console.WriteLine("2. Русский -> Английский");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Введите слово на английском: ");
                string word = Console.ReadLine();
                if (EngToRus.ContainsKey(word))
                    Console.WriteLine($"Перевод на русский: {EngToRus[word]}");
                else Console.WriteLine("Перевод не найден");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Введите слово на русском: ");
                string word = Console.ReadLine();
                if (RusToEng.ContainsKey(word))
                    Console.WriteLine($"Перевод на английский: {RusToEng[word]}");
                else Console.WriteLine("Перевод не найден");
            }
            else Console.WriteLine("Нет такой команды");*/

            // ----------------------------- Обобщения -------------------------------
            // Создаём объекты с разными типами данных
            /*Person<int> tom = new Person<int>(546, "Tom");
            Person<string> bob = new Person<string>("abc123", "Bob");
            Console.WriteLine(tom.Id); // 546
            Console.WriteLine(bob.Id);*/ // abc123
            // В кач-ве ограничений мы можем использовать следующие типы:
            // - new() - универсальный параметр должен представлять тип

            // ------------------ Задача - точки ----------------
            /*Point3D point = new Point3D(3, 4, 2);
            Console.WriteLine(point.ToString());*/

            // ------------------ Самостоятельная задача ---------------
            Sword sword = new Sword(50, "хорошее");
            Person<Sword> person = new Person<Sword>("Вася", "русский", sword);
        }

        public class ClassName<T1, T2, TN> // Обобщённый класс
        {
            // Реализация методов и полей класса,
            // которые работают с обобщёнными типами T1, T2, TN
        }
        class Person<T> // Пример обобщённого класса
        {
            public T Id { get; set; }
            public string Name { get; set; }
            public Person(T id, string name)
            {
                Id = id;
                Name = name;
            }   
        }      
        
    }

}
