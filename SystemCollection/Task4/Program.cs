using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создайте коллекцию типа OrderedDictionary и реализуйте в ней возможность сравнения значений
//ключей.
namespace Task4
{
    class MyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class MyClassComparer : IEqualityComparer
    {
        public new bool Equals(object x, object y)
        {
            if ((x as MyClass).Id==(y as MyClass).Id)
            {
                return true;
            }
            return false;
        }

        public int GetHashCode(object obj)
        {
            return (obj as MyClass).Id;
        }
    }
    static class Program
    {        
        //static public bool Compare(this OrderedDictionary orderedDictionary,int x,int y)
        //{
        //    if (orderedDictionary[x]==orderedDictionary[y])
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        static void Main(string[] args)
        {
            
            OrderedDictionary orderedDictionary = new OrderedDictionary();
            orderedDictionary.Add("Ноль", "Zero");
            orderedDictionary.Add("Один", "one");
            orderedDictionary.Add("Два", "two");
            orderedDictionary.Add("Три", "three");
            orderedDictionary.Add("Четыре", "Four");
            orderedDictionary.Add("Пять", "two");
            foreach (DictionaryEntry item in orderedDictionary)
            {
                Console.WriteLine("{0} {1}",item.Key,item.Value);
            }
            Console.WriteLine(new string('-',20));
            //Console.WriteLine(orderedDictionary.Compare(2,5));
            OrderedDictionary orderedDictionary1 = new OrderedDictionary(new MyClassComparer());
            MyClass myClass1 = new MyClass() { Id = 1, Name = "Женя" };
            MyClass myClass2 = new MyClass() { Id = 2, Name = "Вася" };
            MyClass myClass3 = new MyClass() { Id = 3, Name = "Денис" };
            MyClass myClass4 = new MyClass() { Id = 4, Name = "Дима" };
            MyClass myClass5 = new MyClass() { Id = 4, Name = "Андрей"};
            try
            {
                orderedDictionary1.Add(myClass1, "Student");
                orderedDictionary1.Add(myClass2, "Worker");
                orderedDictionary1.Add(myClass3, "Pensioner");
                orderedDictionary1.Add(myClass4, "Jobless");
                orderedDictionary1.Add(myClass5, "Pupil");//Ошибка: Совпадение ID
            }
            catch (Exception ex)
            {
                Console.WriteLine("Такой ключ уже есть!");
                
            }
            foreach (DictionaryEntry item in orderedDictionary1)
            {
                Console.WriteLine("{0} {1} {2}", ((MyClass)item.Key).Id, ((MyClass)item.Key).Name, item.Value);
            }

            Console.ReadKey();
        }
    }
}
