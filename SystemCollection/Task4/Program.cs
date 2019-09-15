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
    static class Program
    {  static public bool Compare(this OrderedDictionary orderedDictionary,int x,int y)
        {
            if (orderedDictionary[x]==orderedDictionary[y])
            {
                return true;
            }
            return false;
        }
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
            Console.WriteLine(orderedDictionary.Compare(2,5));
            Console.ReadKey();
        }
    }
}
